using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Otf;
using iText.Kernel.Counter.Data;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Signatures;
using Org.BouncyCastle.Asn1.Cms;
using WindowsFormsApp1.AddForms;
using WindowsFormsApp1.dataClasses;
using WindowsFormsApp1.NewFolder1;
using WindowsFormsApp1.Print;

namespace WindowsFormsApp1
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private string      basePath;
        private string      projectPath;
        private string[]    formats;

        private bool isProjectOpen;

        private string[] CER;

        private List<Firm> firmData;
        private List<Site> siteData;
        private List<dataClasses.Module> formImplantData;
        private List<dataClasses.Module> formVariousData;
        private List<Analysis> analysisData;

        private List<dataClasses.Module> missingAnalysis;
        private List<Analysis> expiredAnalysis;

        private int analysisLastId = 0;
        private int formImplantLastId = 0;
        private int formVariousLastId = 0;

        private List<List<MonthElement>> months;

        private string[] dimensions;
        private string[] firmNames;

        StatManager manager;
        PdfPrinter printer;

        public MainForm()
        {
            InitializeComponent();

            this.initializeVariables();

            this.checkAndCreatePath(this.basePath);

            this.printer = new PdfPrinter();

            this.manager = new StatManager(this.basePath);

            manager.loadStats();

            string prjPath = "";
            if((prjPath = manager.getMostUsedPrj()) != "")
            {
                openProject(prjPath, false);
            }
        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void initializeVariables()
        {
            this.basePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // this.basePath= Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine(this.basePath);

            this.formats = new string[]{"gg/dd/yyyy "};

            this.basePath += "\\TerraGroup";

            this.isProjectOpen = false;
            CER = new string[]
            {
                "120301",
                "130205",
                "150102",
                "150106",
                "150107",
                "170302",
                "170405",
                "160601",
                "170101",
                "170107",
                "170302",
                "170405",
                "170504",
                "170508",
                "170604",
                "170904",
                "200201",
            };

            this.dimensions = new string[]
            {
                "Camioncino",
                "2 assi",
                "3 assi",
                "4 assi",
                "bilico"
            };
        }

        private void openProject(string prjPath, bool updateStat)
        {
            this.projectPath = prjPath;

            this.isProjectOpen = true;

            if(updateStat)
                manager.updateProjectCount(prjPath);

            OnProjectOpened();
        }

        private int checkAndCreatePath(string path)
        {
            int ret = 0;
            string[] dirs = path.Split('\\');
            string tempPath = "";
            for (int j = 0; j < dirs.Length; j++)
            {
                tempPath += dirs[j] + "\\";
                if (!Directory.Exists(tempPath))
                {
                    ret += 1;
                    Directory.CreateDirectory(tempPath);
                }
            }

            return ret;
        }

        private void OnProjectOpened()
        {
            this.Text = this.projectPath;

            this.loadAllData();
        }


        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void newProject_Click(object sender, EventArgs e)
        {
            DnewProject dialog = new DnewProject();
            
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.projectPath = this.basePath + "\\" + dialog.name;
                string[] Filenames =
                {
                    "Imprese",
                    "Cantieri",
                    "Analisi",
                    "Registro Impianto",
                    "Registro Varie",
                };
                for (int i = 0; i < Filenames.Length; i++)
                {
                    string path = this.projectPath + "\\" + Filenames[i] + ".tg";
                    Debug.Print(path);

                    this.checkAndCreatePath(this.projectPath);
                    
                    FileStream fil1 = File.Open(path, FileMode.CreateNew);
                    fil1.Close();
                }
            }
        }

        private void openTool_Click(object sender, EventArgs e)
        {
            DopenProject dialog = new DopenProject(this.basePath);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Debug.Print("Opened project " + dialog.projectName + " Located at: " + dialog.projectPath);

                this.openProject(dialog.projectPath, true);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            string[] options =
            {
                "Imprese",
                "Cantieri",
                "Analisi",
                "Registro",
                "Mesi"
            };

            DselectPrint dialog = new DselectPrint(options);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                folder += "\\Registro Rifiuti Stampe";
                checkAndCreatePath(folder);

                this.projectUsable.BackColor = Color.Orange;
                Refresh();

                if (Array.IndexOf(dialog.selected, "Imprese")>=0)
                {
                    // If the return value is -1 (file is already open) show warning dialog
                    while (this.printer.printFirms(folder, this.firmData) == -1)
                        new WarningMessage("Il file Imprese risulta aperto,\n chiudilo prima di continuare").ShowDialog();
                }
                if (Array.IndexOf(dialog.selected, "Cantieri") >= 0)
                {
                    while (this.printer.printSite(folder, this.siteData) == -1)
                        new WarningMessage("Il file Cantieri risulta aperto,\n chiudilo prima di continuare").ShowDialog();
                }
                if (Array.IndexOf(dialog.selected, "Analisi") >= 0)
                {
                    while (this.printer.printAnalysis(folder, this.analysisData) == -1)
                        new WarningMessage("Il file Analisi risulta aperto,\n chiudilo prima di continuare").ShowDialog();
                }
                if (Array.IndexOf(dialog.selected, "Registro") >= 0)
                {
                    while (this.printer.printRegister(folder, this.formImplantData) == -1)
                        new WarningMessage("Il file Registro risulta aperto,\n chiudilo prima di continuare").ShowDialog();
                }
                if(Array.IndexOf(dialog.selected, "Mesi") >= 0)
                {
                    this.checkAndCreatePath(folder + "\\Mesi");
                    while(this.printer.printMonths(folder + "\\Mesi", this.months) == -1)
                        new WarningMessage("Uno dei file dei mesi risulta aperto,\n chiudilo prima di continuare").ShowDialog();
                }

                this.projectUsable.BackColor = Color.Green;
            }

        }

        private void addImpresa_MouseClick(object sender, MouseEventArgs e)
        {

            if (!checkIfOpen())
                return;

            // Show dialog to add firm
            aggiungiImpresa dialog = new aggiungiImpresa();
            // Show dialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string firm = dialog.name + ";" + dialog.dimension  + "-" + dialog.targa;

                StreamWriter file = File.AppendText(this.projectPath + "\\Imprese.tg");
                file.WriteLine(firm);
                file.Close();

                this.LoadFirmData();
            }
        }

        private void addPlate_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            DnewPlate dialog = new DnewPlate(this.firmNames, this.dimensions);

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string[] lines = File.ReadAllLines(this.projectPath + "\\Imprese.tg");

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(dialog.firm))
                    {
                        lines[i] = lines[i] + ";" + dialog.dimension + "-" + dialog.plate;
                        break;
                    }
                }

                File.WriteAllLines(this.projectPath + "\\Imprese.tg", lines);

                this.LoadFirmData();
            }
        }

        private void addAnalysis_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            DnewAnalysis dialog = new DnewAnalysis(this.firmData, this.siteData, this.CER);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string code = dialog.siteName + " - Comune di " + dialog.siteLocation + "; Produttore " + dialog.producer + "; CER " + dialog.CER;
                this.analysisLastId += 1;
                string analysis = this.analysisLastId.ToString() + ";" + dialog.date.ToString() + ";" + dialog.CER + ";" + dialog.siteName + ";" + dialog.siteLocation + ";" + dialog.producer + ";;" + dialog.validity;

                StreamWriter file = File.AppendText(this.projectPath + "\\Analisi.tg");
                file.WriteLine(analysis);
                file.Close();

                this.updateAnalysisData();

            }
        }

        private void addFormImplant_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            DnewModule dialog = new DnewModule(this.firmData, this.siteData, CER, "Implant");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.formImplantLastId += 1;
                string[] buffer =
                {
                    this.formImplantLastId.ToString(),
                    dialog.date,
                    dialog.loadUnload,
                    dialog.producer,
                    dialog.carrier,
                    dialog.carrierDimension+
                    "-"+dialog.carrierPlate,
                    dialog.CER,
                    dialog.Kg.ToString(),
                    dialog.siteLocation,
                    dialog.siteName,
                    dialog.toBreak.ToString(),
                    dialog.note,
                };
                string form = String.Join(";", buffer) + ";";

                StreamWriter file = File.AppendText(this.projectPath + "\\Registro Impianto.tg");
                file.WriteLine(form);
                file.Close();

                this.LoadRegisterImplantData();
                this.LinkRegisterAnalysis();
            }
        }

        private void addFormVarious_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            DnewModule dialog = new DnewModule(this.firmData, this.siteData, CER, "Various");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.formVariousLastId += 1;
                string[] buffer =
                {
                    this.formVariousLastId.ToString(),
                    dialog.date,
                    dialog.loadUnload,
                    dialog.producer,
                    dialog.carrier,
                    dialog.destination,
                    "",
                    dialog.CER,
                    dialog.Kg.ToString(),
                    dialog.siteLocation,
                    dialog.siteName,
                    dialog.toBreak.ToString(),
                    dialog.note,
                };
                string form = String.Join(";", buffer) + ";";

                StreamWriter file = File.AppendText(this.projectPath + "\\Registro Varie.tg");
                file.WriteLine(form);
                file.Close();

                this.LoadRegisterVariousData();
                this.LinkRegisterAnalysis();
            }
        }

        private void addSite_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            // Show dialog to add Building Site
            DnewSite dialog = new DnewSite(siteData);
            // Show dialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.isNewSite)
                {
                    // Is new site so add new line in site file
                    string site = dialog.siteLocation + ";" + dialog.siteName + ";";

                    StreamWriter file = File.AppendText(this.projectPath + "\\Cantieri.tg");
                    file.WriteLine(site);
                    file.Close();
                }
                else
                {
                    // This isn't new site so edit the corresponding line
                    StreamReader fil = new StreamReader(this.projectPath + "\\Cantieri.tg");
                    string line;

                    int index = 0;
                    while ((line = fil.ReadLine()) != null)
                    {
                        if (line.Contains(dialog.siteLocation))
                        {
                            break;
                        }
                        index++;
                    }
                    fil.Close();

                    string[] lines = File.ReadAllLines(this.projectPath + "\\Cantieri.tg");
                    lines[index] += dialog.siteName + ";";

                    File.WriteAllLines(this.projectPath + "\\Cantieri.tg", lines);
                }

                this.LoadSiteData();
            }
            else
            {
                Debug.Print("Canceled");
            }
            dialog.Dispose();
        }

        ///////////////////////////////

        private void firmButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Imprese");
        }

        private void siteButton_Click(object sender, EventArgs e)
        {
            this.DisplayData("Cantieri");
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            this.DisplayData("Analisi");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Registro Impianto");
        }

        private void RegisterVariousButton_Click(object sender, EventArgs e)
        {
            this.DisplayData("Registro Varie");
        }

        private void missingAnalysisButton_Click(object sender, EventArgs e)
        {
            this.DisplayData("Analisi Mancanti");
        }

        private void invalidAnalysisButton_Click(object sender, EventArgs e)
        {
            this.DisplayData("Analisi Scadute");
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Mese");
        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private bool checkIfOpen()
        {
            if (!isProjectOpen)
            {
                DopenWarning dialog = new DopenWarning(this.basePath);
                if (dialog.ShowDialog() == DialogResult.Yes)
                {
                    this.projectPath = dialog.newPath;
                    this.loadAllData();
                    this.isProjectOpen = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private async void loadAllData()
        {

            this.projectUsable.BackColor = Color.Orange;

            Refresh();

            Task firm = this.LoadFirmData();
            Task site =  this.LoadSiteData();
            Task formImplant = this.LoadRegisterImplantData();
            Task formVarious = this.LoadRegisterVariousData();
            Task analysis = this.LoadAnalysisData();

            await firm;
            await site;
            await formImplant;
            await formVarious;
            await analysis;

            this.LinkRegisterAnalysis();
            this.CheckAnalysisValidity();
            await this.CreateMonthTable();

            this.fillTable("Mese");

            this.projectUsable.BackColor = Color.Green;
        }

        private async void updateAnalysisData()
        {
            this.projectUsable.BackColor = Color.Yellow;
            Task t = LoadAnalysisData();
            await t;
            CheckAnalysisValidity();
            LinkRegisterAnalysis();

            this.projectUsable.BackColor = Color.Green;
        }
        
        private async Task LoadFirmData()
        {
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Imprese.tg");

            List<Firm> firms = new List<Firm>();
            this.firmNames = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');

                if (data.Length == 0 || data[0] == null)
                {
                    Debug.Print("Imprese -> WrongLine at: " + i.ToString());
                    continue;
                }

                string name = data[0];
                this.firmNames[i] = name;

                var plates = new List<Tuple<string, string>>();
                if (data.Length == 1)
                {
                    Tuple<string, string> plate = Tuple.Create("", "");
                    plates.Add(plate);
                }
                else
                {
                    for (int j = 1; j < data.Length; j++)
                    {
                        Tuple<string, string> plate;
                        if (data[j].Split('-').Length == 1)
                        {
                            plate = Tuple.Create(data[j].Split('-')[0], "");
                        }
                        else
                        {
                            plate = Tuple.Create(data[j].Split('-')[0], data[j].Split('-')[1]);
                        }
                        if (plate == null)
                            continue;
                        plates.Add(plate);
                    }
                }

                Firm firm = new Firm(name, plates);
                if (firm == null)
                    continue;
                firms.Add(firm);

            }
            this.firmData = firms;

            this.DisplayData("Imprese");

        }

        private async Task LoadSiteData()
        {
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Cantieri.tg");

            List<Site> sites = new List<Site>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "" || lines[i] == " " || lines[i] == null)
                {
                    Debug.Print("wrongline");
                    continue;
                }

                Site site;
                string[] line = lines[i].Split(';');
                if (line.Length > 1)
                {
                    string location = line[0];
                    string[] names = new string[line.Length - 1];
                    for (int j = 0; j < names.Length; j++)
                    {
                        names[j] = line[j + 1];
                    }
                    site = new Site(location, names);
                    sites.Add(site);
                }
                else
                {
                    string location = line[0];
                    string[] names = { "" };
                    site = new Site(location, names);
                    sites.Add(site);
                }
            }

            this.siteData = sites;

            this.DisplayData("Cantieri");
        }

        private async Task LoadRegisterImplantData()
        { 
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Registro Impianto.tg");

            this.formImplantLastId = 0;
            List<dataClasses.Module> formList = new List<dataClasses.Module>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "" || lines[i] == " " || lines[i] == null)
                    continue;

                string[] l = lines[i].Split(';');
                dataClasses.Module form;
                if (l.Length >= 11)
                {
                    int id = 0;
                    Int32.TryParse(l[0], out id);

                    DateTime date = DateTime.Parse(l[1]);
                    string loadUnload = l[2];
                    string producer = l[3];
                    string carrier = l[4];
                    string CER = l[6];
                    int kg = int.Parse(l[7]);
                    string siteLocation = l[8];
                    string siteName = l[9];
                    string note = l[11];
                    bool toBreak = false;
                    if (l[10] == "true")
                        toBreak = true;

                    string plate = "";
                    string dimension = "";
                    if (l[5].Split('-').Length > 1)
                    {
                        plate = l[5].Split('-')[1];
                        dimension = l[5].Split('-')[0];
                    }
                    else
                    {
                        plate = l[6];
                        dimension = "undefined";
                    }

                    if (id > this.formImplantLastId)
                        this.formImplantLastId = id;

                    form = new dataClasses.Module(id, date, loadUnload, producer, carrier, plate, dimension, CER, siteLocation, siteName, toBreak, kg, note);
                    formList.Add(form);
                }
            }
            this.formImplantData = formList;
            this.DisplayData("Registro Impianto");
            /*
            int width = 100;
            StringBuilder table = new StringBuilder();
            table.Append(@"{\rtf1 ");
            var text = "";
            foreach (var el in this.formImplantData)
            {
                table.Append(@"\trowd");
                table.Append(@"\cellx" + width.ToString());


                table.Append(@"\intbl \cell \row");
            }


            table.Append(@"\pard");
            table.Append(@"}");*/

            Debug.Print("Registro -> Found " + this.formImplantData.Count + " readable elements");
        }

        private async Task LoadRegisterVariousData()
        {
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Registro Varie.tg");

            this.formVariousLastId = 0;
            List<dataClasses.Module> formList = new List<dataClasses.Module>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "" || lines[i] == " " || lines[i] == null)
                    continue;

                string[] l = lines[i].Split(';');
                dataClasses.Module form;
                if (l.Length >= 11)
                {
                    int id = 0;
                    Int32.TryParse(l[0], out id);

                    DateTime date = DateTime.Parse(l[1]);
                    string loadUnload = l[2];
                    string producer = l[3];
                    string carrier = l[4];
                    string destination = l[5];
                    string CER = l[7];
                    int kg = int.Parse(l[8]);
                    string siteLocation = l[9];
                    string siteName = l[10];
                    string note = l[12];
                    bool toBreak = false;
                    if (l[11] == "true")
                        toBreak = true;

                    string plate = "";
                    string dimension = "";
                    if (l[6].Split('-').Length > 1)
                    {
                        plate = l[6].Split('-')[1];
                        dimension = l[6].Split('-')[0];
                    }
                    else
                    {
                        plate = l[6];
                        dimension = "undefined";
                    }

                    if (id > this.formVariousLastId)
                        this.formVariousLastId = id;

                    form = new dataClasses.Module(id, date, loadUnload, producer, carrier, plate, dimension, CER, siteLocation, siteName, toBreak, kg, note, destination);
                    formList.Add(form);
                }
            }
            this.formVariousData = formList;

            this.DisplayData("Registro Varie");

            Debug.Print("Registro -> Found " + this.formImplantData.Count + " readable elements");
        }

        private async Task LoadAnalysisData()
        {
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Analisi.tg");

            this.analysisLastId = 0;
            List<Analysis> analysisList = new List<Analysis>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "" || lines[i] == " " || lines[i] == null)
                    continue;

                string[] l = lines[i].Split(';');

                if (l.Length >= 8)
                {
                    if (l[1] == "" && l[2] == "" && l[3] == "")
                        continue;

                    int id = 0;
                    Int32.TryParse(l[0], out id);

                    if (id > this.analysisLastId)
                        this.analysisLastId = id;

                    DateTime date;
                    if (!DateTime.TryParse(l[1], out date))
                    {
                        Console.WriteLine(l[1] + "\t" + id.ToString());
                    }

                    Analysis analysis = new Analysis(id, date, l[2], l[3], l[4], l[5], l[7]);
                    analysisList.Add(analysis);
                }
            }
            this.analysisData = analysisList;

            this.DisplayData("Analisi");

            Debug.Print("Analisi -> Found " + this.analysisData.Count + " readable elements");
        }

        private async Task LinkRegisterAnalysis()
        {
            // check if the form has a linked analysis
            // same CER, same siteLocation, same siteName, sameProducer
            int count = 0;

            List<dataClasses.Module> missing = new List<dataClasses.Module>();

            for(int i = 0; i < this.formImplantData.Count; i++)
            {
                Analysis analysis;
                analysis = this.analysisData.Find(x => (
                this.formImplantData[i].CER.Contains(x.CER) &&
                this.formImplantData[i].siteLocation.Contains(x.siteLocation) &&
                x.siteName == this.formImplantData[i].siteName
                ));
                if (analysis != null || this.formImplantData[i].CER.Contains("170405"))
                {
                    count++;
                }
                else
                {
                    missing.Add(this.formImplantData[i]);
                }
            }

            this.missingAnalysis = missing;
        }

        private async Task CheckAnalysisValidity()
        {
            List<Analysis> expired = new List<Analysis>();
            foreach(var analysis in this.analysisData)
            {
                var aDate = analysis.date.AddYears(1);
                if (DateTime.Compare(aDate, DateTime.Now) < 0)      // if elapsed one year is invalid
                {
                    expired.Add(analysis);
                }
            }
            this.expiredAnalysis = expired;
        }

        private async Task CreateMonthTable()
        {

            checkAndCreatePath(this.projectPath + "\\months");

            List<List<MonthElement>> months = new List<List<MonthElement>>();

            for (int i = 1; i <= 12; i++)
            {
                List<dataClasses.Module> forms;
                forms = this.formImplantData.FindAll(x => (x.date.Month == i));
                if (forms.Count > 0)
                {
                    StreamWriter file = File.CreateText(this.projectPath + "\\months\\" + i.ToString() + ".tg");

                    List<MonthElement> month = new List<MonthElement>();

                    // form in same Month
                    while(forms.Count > 0)
                    {
                        bool jump = false;
                        var form = forms[0];
                        if (form.carrier == "TERRAGROUP")
                            jump = true;

                        var formSameFirm = forms.FindAll(x => (x.carrier == form.carrier));
                        foreach (var el in formSameFirm)
                            forms.Remove(el);

                        if (jump)
                        {
                            continue;
                        }

                        List<VeichleElement> veichleList = new List<VeichleElement>();
                        // forms with same carrier
                        while (formSameFirm.Count > 0)
                        {

                            int normalCount = 0;
                            int toBreakCount = 0;
                            int totalCount = 0;

                            // forms with same carrier veichle
                            var sameVeichle = formSameFirm.FindAll(x => (x.dimension == formSameFirm[0].dimension));
                            foreach (var el in sameVeichle)
                                formSameFirm.Remove(el);

                            List<(DateTime date, int count)> date = new List<(DateTime date, int count)>();
                            foreach (var el in sameVeichle)
                            {
                                var match = date.FindAll(x => (DateTime.Compare(x.date, el.date) == 0));
                                if (match.Count > 0)
                                {
                                    var idx = date.IndexOf(match[0]);
                                    date[idx] = (match[0].date, date[idx].count+1);
                                    if (el.toBreak)
                                        toBreakCount += 1;
                                    else
                                        normalCount += 1;
                                    totalCount += 1;
                                }
                                else
                                {
                                    if (el.toBreak)
                                        toBreakCount += 1;
                                    else
                                        normalCount += 1;
                                    totalCount += 1;
                                    date.Add((el.date, 1));
                                }
                            }

                            VeichleElement newElement = new VeichleElement((sameVeichle[0].plate, sameVeichle[0].dimension), date, normalCount, toBreakCount, totalCount);
                            veichleList.Add(newElement);
                        }

                        MonthElement monthElement = new MonthElement(form.carrier, veichleList);
                        month.Add(monthElement);
                        file.WriteLine(monthElement.getString(" "));
                    }
                    months.Add(month);
                    file.Close();
                }
            }
            this.months = months;
        }
        
        private async Task DisplayData(string type)
        {
            string text = type + "\n";
            this.dataBox.Text = text;
            this.dataBox.Select(0, text.Length);
            this.dataBox.SelectionColor = Color.Black;
            this.dataBox.SelectionFont = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
            this.dataBox.SelectionAlignment = HorizontalAlignment.Center;
            this.dataBox.Select(0, 0);
            text = "";

            var x = this.firmData.ToArray();

            if (type == "Registro Impianto")
                foreach (var el in this.formImplantData)
                    text += el.getString("\t") + "\n";

            if (type == "Registro Varie")
                foreach (var el in this.formImplantData)
                    text += el.getString("\t") + "\n";

            if (type == "Imprese")
                foreach (var el in this.firmData)
                    text += el.getString("\t") + "\n";

            if (type == "Analisi")
                foreach (var el in this.analysisData)
                    text += el.getString("\t") + "\n";

            if (type == "Cantieri")
                foreach (var el in this.siteData)
                    text += el.getString("\t") + "\n";

            if (type == "Analisi Scadute")
                foreach (var el in this.expiredAnalysis)
                    text += el.getString("\t") + "\n";

            if (type == "Analisi Mancanti")
                foreach (var el in this.missingAnalysis)
                    text += el.getString("\t") + "\n";


            this.dataBox.AppendText(text);
        }

        private void fillTable(string type, int index = 0)
        {
            if (type == "Registro Impianto")
            {

                this.table.ColumnCount = 0;
                this.table.RowCount = 0;

                if (this.formImplantData.Count > 0)
                    this.table.ColumnCount = this.formImplantData[0].getString(";").Split(';').Length;
                else return;

                foreach (var el in this.formImplantData[0].getFields())
                {
                    this.table.Columns[Array.IndexOf(formImplantData[0].getFields(), el)].Name = el;
                }

                foreach (var reg in this.formImplantData)
                {
                    this.table.Rows.Add(reg.getOjb());
                }
            }
            if (type == "Mese")
            {
                this.table.ColumnCount = 0;
                this.table.RowCount = 0;
                if (this.months.Count > index)
                {
                    var month = this.months[index];
                    if (month.Count > 0)
                    {
                        var currYear = month[0].veichles[0].dates[0].date.Year;
                        var currMonth = months.IndexOf(month) + 1;
                        this.table.ColumnCount = DateTime.DaysInMonth(currYear, currMonth) + 2 + 2 + 1;

                        this.table.Columns[0].Name = "Impresa";
                        this.table.Columns[1].Name = "Mezzo";

                        int n = 0;
                        // Days
                        for (int day = 1; day <= DateTime.DaysInMonth(currYear, currMonth); day++)
                        {
                            var date = day.ToString() + "/" + currMonth.ToString() + "/" + currYear.ToString();
                            n = day + 1;
                            this.table.Columns[n].Name = date;
                        }

                        this.table.Columns[n + 1].Name = "N";
                        this.table.Columns[n + 2].Name = "P";
                        this.table.Columns[n + 3].Name = "Totale";


                        foreach (var element in month)
                        {
                            List<object> line = new List<object>();

                            if (month.IndexOf(element) == 0)
                                line.Add(element.firm);
                            else
                                line.Add("");

                            // For every veichle in this current firm
                            foreach (var veichle in element.veichles)
                            {
                                // Create cell with veichle informations
                                line.Add(veichle.veichle.plate);

                                // Foreach day in this current month
                                for (int day = 1; day <= DateTime.DaysInMonth(currYear, currMonth); day++)
                                {
                                    // Create cell with the count of veichle trips
                                    // If 0 trip, fill with nothing
                                    var datestring = day.ToString() + "/" + currMonth.ToString() + "/" + currYear.ToString();
                                    var date = DateTime.Parse(datestring);

                                    if (veichle.dates.FindAll(x => (x.date == date)).Count > 0)
                                    {
                                        var count = veichle.dates.FindAll(x => (x.date == date))[0].count;
                                        line.Add(count.ToString());
                                    }
                                    else
                                    {
                                        line.Add("");
                                    }
                                }

                                // Create cell whith total trip count int this current month for this specific veichle
                                line.Add(veichle.normalCount);
                                line.Add(veichle.toBreakCount);
                                line.Add(veichle.totalCount);
                                this.table.Rows.Add(line.ToArray());
                            }
                        }

                    }

                }
            }

            if(type == "Imprese")
            {
                this.table.ColumnCount = 0;
                this.table.RowCount = 0;

                if (this.firmData.Count > 0)
                    this.table.ColumnCount = this.firmData[0].getString(";").Split(';').Length;
                else return;

                foreach (var el in this.firmData[0].getFields())
                {
                    this.table.Columns[Array.IndexOf(this.firmData[0].getFields(), el)].Name = el;
                }

                foreach (var el in this.firmData)
                {

                    foreach(var plate in el.targhe)
                    {
                        List<object> line = new List<object>();
                        if (el.targhe.IndexOf(plate) == 0)
                        {
                            line.Add(el.name);
                            line.Add(plate);
                        }
                        else
                        {
                            line.Add("");
                            line.Add(plate);
                        }
                        this.table.Rows.Add(line.ToArray());
                    }

                }
            }
        }
    }
}