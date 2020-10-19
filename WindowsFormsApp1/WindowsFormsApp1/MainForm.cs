using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font;
using iText.IO.Font.Otf;
using iText.Kernel.Counter.Data;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Signatures;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Cmp;
using WindowsFormsApp1.AddForms;
using Rifiuti.dataClasses;
using WindowsFormsApp1.Print;
using WindowsFormsApp1.dataClasses;
using Rifiuti.EditForms;
using DataGridViewAutoFilter;
using Rifiuti.dataClasses;

namespace WindowsFormsApp1
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private string      basePath;
        private string      projectPath;
        private string      currentTableDataType;

        private bool isProjectOpen;

        private int[] CER;

        private List<Firm> firmData = new List<Firm>();
        private List<Site> siteData = new List<Site>();
        private List<Analysis> analysisData = new List<Analysis>();
        private List<dataClasses.Module> formImplantData = new List<dataClasses.Module>();
        private List<dataClasses.Module> formVariousData = new List<dataClasses.Module>();
        private List<ExtraProcessing> extraProcessingData = new List<ExtraProcessing>();
        private List<InitialStatus> CERInitialStatusData = new List<InitialStatus>();

        private List<dataClasses.Module> missingAnalysis = new List<dataClasses.Module>();
        private List<Analysis> expiredAnalysis = new List<Analysis>();

        private int analysisLastId = 0;
        private int formImplantLastId = 0;
        private int formVariousLastId = 0;

        private List<List<MonthElement>> months = new List<List<MonthElement>>();
        private string[] monthNames;

        private List<StatusElement> status = new List<StatusElement>();

        private string[] dimensions;
        private string[] firmNames;

        private string filter;
        private List<object> filterControls = new List<object>();
        StatusStrip statusStrip1 = new StatusStrip();
        ToolStripStatusLabel filterStatusLabel = new ToolStripStatusLabel();
        ToolStripStatusLabel showAllLabel = new ToolStripStatusLabel("Show &All");

        FilterManager filterM;
        StatManager manager;
        PdfPrinter printer;

        public MainForm()
        {
            InitializeComponent();

            this.initializeVariables();

            this.checkAndCreatePath(this.basePath);

            this.printer = new PdfPrinter();

            this.manager = new StatManager(this.basePath);

            this.filterM = new FilterManager();

            manager.loadStats();

            string prjPath = "";
            if((prjPath = manager.getMostUsedPrj()) != "")
            {
                if (checkPath(prjPath))
                    openProject(prjPath, false);
                else
                    manager.removeProject(prjPath);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            checkIfOpen();
        }


        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void initializeVariables()
        {
            this.basePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // this.basePath= Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine(this.basePath);

            this.basePath += "\\TerraGroup";

            this.isProjectOpen = false;
            this.CER = new int[]
            {
                170904,
                170302,
                170508,
                170504,
                120301,
                130205,
                150102,
                150106,
                150107,
                170405,
                160601,
                170101,
                170107,
                170604,
                200201,
            };

            this.dimensions = new string[]
            {
                "Camioncino",
                "2 assi",
                "3 assi",
                "4 assi",
                "bilico"
            };
            this.monthNames = new string[]
            {
                "Gennaio",
                "Febbraio",
                "Marzo",
                "Aprile",
                "Maggio",
                "Giugno",
                "Luglio",
                "Agosto",
                "Settembre",
                "Ottobre",
                "Novembre",
                "Dicembre"
            };
            this.monthComboBox.Items.AddRange(this.monthNames);
            this.monthComboBox.SelectedIndex = 0;

            Console.WriteLine(this.CER);

            /*
            // Initialize AutoFilter for table
            this.table.BindingContextChanged += new EventHandler(dataGridView1_BindingContextChanged);
            this.table.KeyDown += new KeyEventHandler(dataGridView1_KeyDown);
            this.table.DataBindingComplete +=
                new DataGridViewBindingCompleteEventHandler(
                dataGridView1_DataBindingComplete);

            showAllLabel.Visible = false;
            showAllLabel.IsLink = true;
            showAllLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            showAllLabel.Click += new EventHandler(showAllLabel_Click);

            statusStrip1.Cursor = Cursors.Default;
            statusStrip1.Items.AddRange(new ToolStripItem[] {
                filterStatusLabel, showAllLabel });

            this.Controls.AddRange(new Control[] {
                this.table, statusStrip1 });
            */
        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void openProject(string prjPath, bool updateStat)
        {
            this.projectPath = prjPath;

            this.isProjectOpen = true;

            if(updateStat)
                manager.updateProjectCount(prjPath);

            OnProjectOpened();
        }

        private bool checkPath(string path)
        {
            bool ret = false;
            if (Directory.Exists(path))
                ret = true;

            return ret;
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
                    "Lavorazioni Extra"
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

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        
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
                this.sortAll();
                this.updateTable();
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
                this.sortAll();
                this.updateTable();
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
                this.sortAll();
                this.updateTable();
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
                    dialog.Other,
                    dialog.note,
                };
                string form = String.Join(";", buffer) + ";";

                StreamWriter file = File.AppendText(this.projectPath + "\\Registro Impianto.tg");
                file.WriteLine(form);
                file.Close();

                this.LoadRegisterImplantData();
                this.LinkRegisterAnalysis();
                this.CreateMonthTable();
                this.sortAll();
                this.updateTable();
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
                    dialog.Other,
                    dialog.note,
                };
                string form = String.Join(";", buffer) + ";";

                StreamWriter file = File.AppendText(this.projectPath + "\\Registro Varie.tg");
                file.WriteLine(form);
                file.Close();

                this.LoadRegisterVariousData();
                this.LinkRegisterAnalysis();
                this.sortAll();
                this.updateTable();
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
                this.sortAll();
                this.updateTable();
            }
            else
            {
                Debug.Print("Canceled");
            }
            dialog.Dispose();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Same callback for every button used to modify data
        private void editButtonsClicked(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            if(btn.Name == "EditFirm")
            {
                DEditFirm dialog = new DEditFirm(this.firmData, this.dimensions);

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    var idx = this.firmData.IndexOf(dialog.oldFirm);
                    this.firmData[idx] = dialog.newFirm;

                    List<string> lines = new List<string>();
                    foreach (var element in this.firmData)
                        lines.Add(element.getString(";"));

                    File.WriteAllLines(this.projectPath + "\\Imprese.tg", lines);
                    this.updateTable();
                }
            }
            if(btn.Name == "EditFormImplant")
            {

            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void firmButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Imprese");
        }

        private void siteButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Cantieri");
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Analisi");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Registro Impianto");
        }

        private void RegisterVariousButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Registro Varie");
        }

        private void missingAnalysisButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Analisi Mancanti");
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Mese");
        }

        private void monthComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.currentTableDataType == "Mese")
                this.fillTable("Mese");
        }

        private void situationButton_Click(object sender, EventArgs e)
        {
            this.fillTable("Situazione");
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

            // UI loading indicator
            this.projectUsable.BackColor = Color.Orange;

            Refresh();

            // Loading data from project files
            Task firm           = this.LoadFirmData();
            Task site           =  this.LoadSiteData();
            Task formImplant    = this.LoadRegisterImplantData();
            Task formVarious    = this.LoadRegisterVariousData();
            Task analysis       = this.LoadAnalysisData();
            Task extra          = this.LoadExtraData();

            await firm;
            await site;
            await formImplant;
            await formVarious;
            await analysis;
            await extra;

            this.sortAll();

            this.LinkRegisterAnalysis();
            this.CheckAnalysisValidity();

            // Creating tables
            await this.CreateMonthTable();
            this.CreateStatusTable();

            // Displaying tables
            this.fillTable("Situazione");
            
            // UI loading indicator
            this.projectUsable.BackColor = Color.Green;

            Refresh();
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
                string location = line[0];
                List<string> names = new List<string>();

                if (line.Length > 1)
                    for (int j = 1; j < line.Length; j++)
                        names.Add(line[j]);
                else
                    names.Add("");

                site = new Site(location, names);
                sites.Add(site);
            }

            this.siteData = sites;
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

                    int CER = 0;
                    Int32.TryParse(l[6], out CER);

                    DateTime date = DateTime.Parse(l[1]);
                    string loadUnload = l[2];
                    string producer = l[3];
                    string carrier = l[4];
                    int kg = int.Parse(l[7]);
                    string siteLocation = l[8];
                    string siteName = l[9];
                    string note = l[11];
                    string toBreak = l[10];

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

            Debug.Print("Registro Impianto -> Found " + this.formImplantData.Count + " readable elements");
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

                    int CER = 0;
                    Int32.TryParse(l[7], out CER);

                    DateTime date = DateTime.Parse(l[1]);
                    string loadUnload = l[2];
                    string producer = l[3];
                    string carrier = l[4];
                    string destination = l[5];
                    int kg = int.Parse(l[8]);
                    string siteLocation = l[9];
                    string siteName = l[10];
                    string note = l[12];
                    string toBreak = l[11];

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

            Debug.Print("Registro Varie -> Found " + this.formImplantData.Count + " readable elements");
        }

        private async Task LoadExtraData()
        {
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Lavorazioni Extra.tg");

            this.extraProcessingData = new List<ExtraProcessing>();
            this.CERInitialStatusData = new List<InitialStatus>();

            foreach (var e in lines)
            {
                if (e.Contains("Riporto"))
                {
                    var line = e.Split(';');
                    for (int i = 1; i < line.Length; i += 2)
                    {
                        InitialStatus stat = new InitialStatus(int.Parse(line[i]), int.Parse(line[i+1]));
                        this.CERInitialStatusData.Add(stat);
                    }
                    continue;
                }

                var date = DateTime.Parse(e.Split(';')[0]);
                var type = e.Split(';')[1];

                ExtraProcessing ext = new ExtraProcessing(date, type);
                this.extraProcessingData.Add(ext);
            }
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

                    int CER = 0;
                    Int32.TryParse(l[2], out CER);

                    int id = 0;
                    Int32.TryParse(l[0], out id);

                    if (id > this.analysisLastId)
                        this.analysisLastId = id;

                    DateTime date;
                    if (!DateTime.TryParse(l[1], out date))
                    {
                        Console.WriteLine(l[1] + "\t" + id.ToString());
                    }

                    if (DateTime.Compare(date.AddYears(1), DateTime.Now) < 0)
                    {
                        l[7] = "False";
                    }
                    else
                    {
                        l[7] = "True";
                    }

                    Analysis analysis = new Analysis(id, date, CER, l[3], l[4], l[5], l[7]);
                    analysisList.Add(analysis);
                }
            }
            this.analysisData = analysisList;

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
                this.formImplantData[i].CER == x.CER &&
                this.formImplantData[i].siteLocation.Contains(x.siteLocation) &&
                x.siteName == this.formImplantData[i].siteName
                ));
                if (analysis != null || this.formImplantData[i].CER == 170405)
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

            List<List<MonthElement>> months = new List<List<MonthElement>>();

            for (int i = 1; i <= 12; i++)
            {
                List<dataClasses.Module> forms;
                forms = this.formImplantData.FindAll(x => (x.date.Month == i));
                if (forms.Count > 0)
                {
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
                            int asphaltCount = 0;
                            int totalCount = 0;

                            // forms with same carrier veichle
                            var sameVeichle = formSameFirm.FindAll(x => (x.dimension == formSameFirm[0].dimension));
                            foreach (var el in sameVeichle)
                                formSameFirm.Remove(el);

                            List<(DateTime date, int count)> date = new List<(DateTime date, int count)>();
                            foreach (var el in sameVeichle)
                            {
                                var match = date.FindAll(x => (x.date.Date == el.date.Date));
                                if (match.Count > 0)
                                {
                                    var idx = date.IndexOf(match[0]);
                                    date[idx] = (match[0].date, date[idx].count+1);
                                    if (el.toBreak == "p")
                                        toBreakCount += 1;
                                    else if (el.toBreak == "a")
                                        asphaltCount += 1;
                                    else
                                        normalCount += 1;
                                    totalCount += 1;
                                }
                                else
                                {
                                    if (el.toBreak == "p")
                                        toBreakCount += 1;
                                    else if (el.toBreak == "a")
                                        asphaltCount += 1;
                                    else
                                        normalCount += 1;
                                    totalCount += 1;
                                    date.Add((el.date, 1));
                                }
                            }

                            VeichleElement newElement = new VeichleElement((sameVeichle[0].plate, sameVeichle[0].dimension), date, normalCount, toBreakCount, asphaltCount, totalCount);
                            veichleList.Add(newElement);
                        }

                        MonthElement monthElement = new MonthElement(form.carrier, veichleList);
                        month.Add(monthElement);
                    }
                    month = month.OrderBy(x => x.firm).ToList();
                    months.Add(month);
                }
            }
            this.months = months;
        }



        // Table with situation and movements each day for every year.
        private void CreateStatusTable()
        {
            List<StatusElement> statusElements = new List<StatusElement>();
            List<CERElement> CERs = new List<CERElement>();
            List<(int cer, int total)> status = new List<(int, int)>();

            // Initialize status for each CER
            foreach (var cer in this.CER)
                status.Add((cer, 0));

            // Initializing list with empty elements
            foreach (var el in this.CER) {
                // If there is a initial status, add it to the total of the corresponding CER
                var existingStatus = this.CERInitialStatusData.Find(x => x.status.CER == el);
                if (existingStatus != null)
                    CERs.Add(new CERElement(el, 0, 0, existingStatus.status.quantity));
                else
                    CERs.Add(new CERElement(el, 0, 0, 0));
            }

            // Finding the right year by looking at the first form
            int currentYear = 0;
            if (this.formImplantData.Count > 0)
                currentYear = this.formImplantData[0].date.Year;
            else
                return;

            // Creating list with all dates in this current year
            List<DateTime> dates = new List<DateTime>();
            for (int month = 1; month <= 12; month++)
                for (int day = 1; day < DateTime.DaysInMonth(currentYear, month); day++)
                    dates.Add(DateTime.Parse(day.ToString() + "/" + month.ToString() + "/" + currentYear.ToString()));

            // Cycling in each date
            foreach(var date in dates)
            {
                // Set to zero load and unload that are values valid for only one day
                for (int i = 0; i < CERs.Count; i++)
                {
                    CERs[i].load = 0;
                    CERs[i].unload = 0;
                }

                // Looking at only the forms in the current day
                var elements = this.formImplantData.FindAll(x => x.date.Date == date.Date);

                bool hasLoaded = false;
                bool hasUnloaded = false;

                int total = 0;
                // Cycling between each element, all are of the same day
                foreach(var element in elements)
                {
                    // Looking for the correct index
                    var cer = CERs.Find(x => x.CER == element.CER);
                    int idx = CERs.IndexOf(cer);

                    // If is a load operation add the kg to the total, else subtract
                    if (element.loadUnload == "Carico")
                    {
                        cer.load += element.kg;
                        cer.CERTotal += element.kg;
                        hasLoaded = true;
                        total += element.kg;        // Daily total, is only positive count
                    }
                    else
                    {
                        cer.unload += element.kg;
                        cer.CERTotal -= element.kg;
                        hasUnloaded = true;
                    }

                    CERs[idx] = cer;
                }

                // Creating the list containing all the operations for each cer
                var newCERs = new List<CERElement>();
                foreach(var el in CERs)
                    newCERs.Add(new CERElement(el.CER, el.load, el.unload, el.CERTotal));

                var extraData = this.extraProcessingData.Find(x => x.date.Date == date.Date);
                if (extraData != null) {

                    int q1 = 0;
                    int q2 = 0;
                    int q3 = 0;
                    int processed = 0;

                    List<int> cers = new List<int>
                    {
                        170904,
                        170302,
                        170101,
                        170107,
                        170508,
                        170504
                    };

                    foreach (var cer in cers)
                    {
                        var cerElement = newCERs.Find(x => x.CER == cer);
                        processed += cerElement.unload;
                    }

                    processed = (int)(processed / 1600);

                    if(extraData.type == "v")
                    {
                        q1 = (int) (processed * 0.6);
                        q3 = (int)(processed * 0.4);
                    }
                    else
                    {
                        q2 = processed;
                    }
                    Console.WriteLine(extraData.date.ToString() +"\t" + processed.ToString() + "\t" + q1.ToString() + "\t" + q2.ToString() + "\t" + q3.ToString());
                    var extraEl = new ExtraProcessingElement(extraData.type, processed, q1, q2, q3);
                    // Creating element with all operation for each cer and also daily informations
                    statusElements.Add(new StatusElement(date, total, newCERs, hasLoaded, hasUnloaded, extraEl));
                }
                else
                {
                    // Creating element with all operation for each cer and also daily informations
                    statusElements.Add(new StatusElement(date, total, newCERs, hasLoaded, hasUnloaded));
                }
            }


            this.status = statusElements;

        }

        private void fillTable(string type)
        {
            if(type != this.currentTableDataType)
            {
                this.filterM.ClearFilters();
                this.currentTableDataType = type;
                this.setupFilterBoxes();
            }
            
            this.currentTableDataType = type;

            // Initialize Dataset
            int dataIndex = 0;
            DataSet ds = new DataSet();
            ds.Tables.Add();

            // Set Filter Context
            this.filterM.SetFilterContext(type);

            List<(int index, Color color)> hilightRows = new List<(int index, Color color)>();
            List<object> rows = new List<object>();

            var dv = new DataView(ds.Tables[dataIndex]);
            this.table.DataSource = dv;


            this.table.ColumnHeadersVisible = false;
            if (type == "Registro Impianto")
            {

                if (this.formImplantData.Count == 0)
                    return;

                var fields = this.formImplantData[0].getFields("Implant");

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
                }

                foreach (var reg in this.formImplantData)
                {
                    ds.Tables[dataIndex].Rows.Add(reg.getObj("Implant"));
                }
            }

            if (type == "Registro Varie")
            {

                if (this.formVariousData.Count == 0)
                    return;

                var fields = this.formVariousData[0].getFields("");

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
                }

                foreach (var reg in this.formVariousData)
                {
                    ds.Tables[dataIndex].Rows.Add(reg.getObj(""));
                }
            }

            if (type == "Mese")
            {
                int index = this.monthComboBox.SelectedIndex;

                if (this.months != null && this.months.Count > index)
                {
                    var month = this.months[index];
                    if (month.Count > 0)
                    {
                        var currYear = month[0].veichles[0].dates[0].date.Year;
                        var currMonth = months.IndexOf(month) + 1;

                        ds.Tables[dataIndex].Columns.Add("Impresa");
                        ds.Tables[dataIndex].Columns.Add("Mezzo");

                        // Days
                        for (int day = 1; day <= DateTime.DaysInMonth(currYear, currMonth); day++)
                        {
                            var date = day.ToString() + "/" + currMonth.ToString() + "/" + currYear.ToString();
                            ds.Tables[dataIndex].Columns.Add(date);
                        }

                        ds.Tables[dataIndex].Columns.Add("N");
                        ds.Tables[dataIndex].Columns.Add("P");
                        ds.Tables[dataIndex].Columns.Add("A");
                        ds.Tables[dataIndex].Columns.Add("Totale");

                        foreach (var element in month)
                        {
                            // For every veichle in this current firm
                            foreach (var veichle in element.veichles)
                            {
                                List<object> line = new List<object>();

                                if (element.veichles.IndexOf(veichle) == 0)
                                    line.Add(element.firm);
                                else
                                    line.Add("");
                                // Create cell with veichle informations
                                line.Add(veichle.veichle.plate);

                                // Foreach day in this current month
                                for (int day = 1; day <= DateTime.DaysInMonth(currYear, currMonth); day++)
                                {
                                    // Create cell with the count of veichle trips
                                    // If 0 trip, fill with nothing
                                    var datestring = day.ToString() + "/" + currMonth.ToString() + "/" + currYear.ToString();
                                    var date = DateTime.Parse(datestring);

                                    if (veichle.dates.FindAll(x => (x.date.Date == date.Date)).Count > 0)
                                    {
                                        var count = veichle.dates.FindAll(x => (x.date.Date == date.Date))[0].count;
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
                                line.Add(veichle.asphaltCount);
                                line.Add(veichle.totalCount);
                                ds.Tables[dataIndex].Rows.Add(line.ToArray());
                            }
                        }
                    }

                }
            }

            if (type == "Imprese")
            {

                if (this.firmData.Count == 0)
                    return;

                var fields = this.firmData[0].getFields();

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
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
                        ds.Tables[dataIndex].Rows.Add(line.ToArray());
                    }

                }
            }

            if (type == "Analisi")
            {

                if (this.analysisData.Count == 0)
                    return;

                var fields = this.analysisData[0].getFields();

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
                }

                foreach (var el in this.analysisData)
                {
                    ds.Tables[dataIndex].Rows.Add(el.getObj());


                    if (el.validity == "False")
                        hilightRows.Add((this.analysisData.IndexOf(el), Color.IndianRed));
                    
                }
            }

            if (type == "Analisi Mancanti")
            {

                if (this.missingAnalysis.Count == 0)
                    return;

                var fields = this.missingAnalysis[0].getFields("Impianto");

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
                }

                foreach (var el in this.missingAnalysis)
                {
                    ds.Tables[dataIndex].Rows.Add(el.getObj("Impianto"));
                }
            }

            if (type == "Situazione")
            {

                if (this.status.Count == 0)
                    return;

                var reqCERs = this.CER;

                var fields = this.status[0].getFields(reqCERs);

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
                }

                foreach (var el in this.status)
                {

                    ds.Tables[dataIndex].Rows.Add(el.getObj());


                    rows.Add(el.getObj());
                    
                    // Changing row style to hilight activity
                    if(el.hasLoaded && el.hasUnloaded)
                        hilightRows.Add((this.status.IndexOf(el), Color.MediumPurple));
                    else if(el.hasLoaded)
                        hilightRows.Add((this.status.IndexOf(el), Color.LightGreen));
                    else if(el.hasUnloaded)
                        hilightRows.Add((this.status.IndexOf(el), Color.IndianRed));
                }
            }

            if (type == "Cantieri")
            {

                if (this.siteData.Count == 0)
                    return;
                var fields = this.siteData[0].getFields();

                for (int i = 0; i < fields.Length; i++)
                {
                    ds.Tables[dataIndex].Columns.Add();
                    ds.Tables[dataIndex].Columns[i].ColumnName = fields[i];
                }

                foreach (var el in this.siteData)
                {

                    foreach (var name in el.names)
                    {
                        List<object> line = new List<object>();
                        if (el.names.IndexOf(name) == 0)
                        {
                            line.Add(el.location);
                            line.Add(name);
                        }
                        else
                        {
                            line.Add("");
                            line.Add(name);
                        }
                        ds.Tables[dataIndex].Rows.Add(line.ToArray());
                    }
                }
            }

            dv = new DataView(ds.Tables[dataIndex]);

            // Enabing filter on rows
            this.filter = this.filterM.ParseFilters();
            if (this.filter != "")
                dv.RowFilter = filter;

            this.table.DataSource = dv;

            this.stylizeTable();

            this.table.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont.FontFamily, 12);

            /*
            for (int i = 0; i < this.table.RowCount; i++)
            {
                var el = hilightRows.Find(x => x.index == i);
                if (el != (null,null))
                    this.table.Rows[i].DefaultCellStyle.BackColor = el.color;
                // this.table.Rows[el.index].DefaultCellStyle.ForeColor = el.color;
            }
            */

            // Using double buffer to speedup UI updates like scrolling
            Type typ = this.table.GetType();
            PropertyInfo pi = typ.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.table, true, null);

            this.table.ColumnHeadersVisible = true;
        }

        private void stylizeTable()
        {
            if(this.currentTableDataType == "Situazione")
            {
                for(int i = 0; i <this.table.RowCount; i++)
                {

                    var fields = this.status[0].getFields(this.CER).ToList();
                    /*
                    if (((StatusElement)row).hasLoaded && ((StatusElement)row).hasUnloaded)
                        ((DataGridViewRow)row).DefaultCellStyle.BackColor = Color.MediumPurple;
                    else if (((StatusElement)row).hasLoaded)
                        ((DataGridViewRow)row).DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (((StatusElement)row).hasUnloaded)
                        ((DataGridViewRow)row).DefaultCellStyle.BackColor = Color.IndianRed;
                    */
                }
                for (int i = 0; i < this.table.ColumnCount; i++)
                {
                    if ((i) % 3 == 1)
                    {
                        this.table.Columns[i].DividerWidth = 1;
                    }
                }
                this.table.GridColor = Color.FromArgb(20, 20, 20);
            }
        }

        private void updateTable()
        {
            this.fillTable(currentTableDataType);
        }

        private void sortAll()
        {
            this.analysisData           = this.analysisData.OrderByDescending(x => x.id).ToList();
            this.formImplantData        = this.formImplantData.OrderByDescending(x => x.id).ToList();
            this.formVariousData        = this.formVariousData.OrderByDescending(x => x.id).ToList();
            this.firmData               = this.firmData.OrderBy(x => x.name).ToList();
            this.siteData               = this.siteData.OrderBy(x => x.location).ToList();
        }


        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-------------------------------------FILTERS SECTION-------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void setupFilterBoxes()
        {
            /*
            // Adding firm names to comboBox
            List<string> firmNames = new List<string>();
            foreach(var el in this.firmData)
                firmNames.Add(el.name);

            this.filterProducer.Items.AddRange(firmNames.ToArray());

            */


            // Clearing list of filter controls
            foreach(var el in this.filterControls)
                this.Controls.Remove((Control)el);

            int offsetX = 40;
            int span = 16;
            int zeroX = this.filterClearButton.Location.X + this.filterClearButton.Width + span;
            int zeroY = this.filterClearButton.Location.Y + this.filterClearButton.Height / 3;
            int currentX = zeroX;

            // Adding filter controls
            if(this.currentTableDataType == "Situazione" || this.currentTableDataType == "Analisi") {
                
                // Start Date
                var e = new DateTimePicker();    
                e.Location = new System.Drawing.Point(currentX, zeroY);
                e.Name = "Start Date";
                e.ValueChanged += new EventHandler(this.filterDateTimePickerChanged);

                this.Controls.Add(e);
                this.filterControls.Add(e);
                currentX += e.Width + span;
                // End Date
                e = new DateTimePicker();
                e.Location = new System.Drawing.Point(currentX, zeroY);
                e.Name = "End Date";
                e.ValueChanged += new EventHandler(this.filterDateTimePickerChanged);

                this.Controls.Add(e);
                this.filterControls.Add(e);

                currentX += e.Width + span;
            }
            else if (this.currentTableDataType == "Registro Impianto" || this.currentTableDataType == "Registro Varie")
            {

                // Adding firm names to comboBox
                List<string> firmNames = new List<string>();
                foreach (var el in this.firmData)
                    firmNames.Add(el.name);

                // Producer ComboBox
                var e = new ComboBox();
                e.Location = new System.Drawing.Point(currentX, zeroY);
                e.Name = "Produttore";
                e.Items.AddRange(firmNames.ToArray());
                e.SelectedIndexChanged += new EventHandler(this.filterComboClicked);

                this.Controls.Add(e);
                this.filterControls.Add(e);
                currentX += e.Width + span;

                // Start Date
                var d = new DateTimePicker();
                d.Location = new System.Drawing.Point(currentX, zeroY);
                d.Name = "Start Date";
                d.ValueChanged += new EventHandler(this.filterDateTimePickerChanged);

                this.Controls.Add(d);
                this.filterControls.Add(d);
                currentX += d.Width + span;
                // End Date
                d = new DateTimePicker();
                d.Location = new System.Drawing.Point(currentX, zeroY);
                d.Name = "End Date";
                d.ValueChanged += new EventHandler(this.filterDateTimePickerChanged);

                this.Controls.Add(d);
                this.filterControls.Add(d);

                currentX += d.Width + span;

            }
            
            
            
            if (this.currentTableDataType == "Analisi")
            {
                // Validity ComboBox
                var e = new ComboBox();
                e.Location = new System.Drawing.Point(currentX, zeroY);
                e.Name = "Validità";
                e.Items.Add("True");
                e.Items.Add("False");
                e.SelectedIndexChanged += new EventHandler(this.filterComboClicked);

                this.Controls.Add(e);
                this.filterControls.Add(e);

                currentX += e.Width + span;
            }
        }

        private void filterComboClicked(object sender, EventArgs e)
        {
            this.filterM.addModifiedFilter(((ComboBox)sender).Name);
            this.filterM.addFilter(((ComboBox)sender).Name, ((ComboBox)sender).SelectedItem);
            this.updateTable();
        }

        private void filterDateTimePickerChanged(object sender, EventArgs e)
        {
            this.filterM.addModifiedFilter(((DateTimePicker)sender).Name);
            this.filterM.addFilter(((DateTimePicker)sender).Name, ((DateTimePicker)sender).Value);
            this.updateTable();
        }

        private void filterClearButton_Click(object sender, EventArgs e)
        {
            this.filterM.ClearFilters();
            this.updateTable();
        }
    }
}