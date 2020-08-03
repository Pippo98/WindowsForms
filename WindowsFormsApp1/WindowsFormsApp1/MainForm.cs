using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Otf;
using iText.Kernel.Geom;
using iText.Signatures;
using WindowsFormsApp1.AddForms;
using WindowsFormsApp1.dataClasses;
using WindowsFormsApp1.NewFolder1;
using WindowsFormsApp1.Print;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private string      basePath;
        private string      projectPath;

        private bool isProjectOpen;

        private string[] CER;

        private List<Firm> firmData;
        private List<Site> siteData;
        private List<Register> registerData;
        private List<Analysis> analysisData;

        private string[] dimensions;
        private string[] firmNames;

        PdfPrinter printer;

        public MainForm()
        {
            InitializeComponent();

            this.initializeVariables();

            this.checkAndCreatePath(this.basePath);

            //Environment.SpecialFolder.MyDocuments;

            this.printer = new PdfPrinter();

            analysisBox.Visible = false;
            firmBox.Visible = false;
            siteBox.Visible = false;
            registerBox.Visible = true;
            invalidAnalysisBox.Visible = false;

        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void initializeVariables()
        {
            this.basePath = "C:\\Users\\Marco Faccini\\TerraGroup";
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
                    "Registro",
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

        private void checkAndCreatePath(string path)
        {
            string[] dirs = path.Split('\\');
            string tempPath = "";
            for (int j = 0; j < dirs.Length; j++)
            {
                tempPath += dirs[j] + "\\";
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
            }
        }

        private void OnProjectOpened()
        {
            this.loadAllData();
        }


        private string firmString(Firm firm)
        {
            string text = "";

            text += firm.name;
            for (int i = 0; i < firm.targhe.Count; i++)
                text += "\t" + firm.targhe[i].Item2 + " " + firm.targhe[i].Item1;
            text += "\n";

            return text;
        }

        private string siteString(Site site)
        {
            string text = "";

            text += site.location;

            for (int i = 0; i < site.names.Length; i++)
                text += "\t" + site.names[i];
            text += "\n";
            return text;
        }


        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void openTool_Click(object sender, EventArgs e)
        {
            DopenProject dialog = new DopenProject(this.basePath);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Debug.Print("Opened project " + dialog.projectName + " Located at: " + dialog.projectPath);

                this.projectPath = dialog.projectPath;

                this.isProjectOpen = true;

                OnProjectOpened();
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
                "Analisi"
            };

            DselectPrint dialog = new DselectPrint(options);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                folder += "\\Registro Rifiuti Stampe";
                checkAndCreatePath(folder);

                if (Array.IndexOf(dialog.selected, "Imprese")>=0)
                {
                    this.printer.printFirms(folder, this.firmData);
                }
                if (Array.IndexOf(dialog.selected, "Analisi") >= 0)
                {
                    this.printer.printAnalysis(folder, this.analysisData);
                }
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
                        lines[i] = lines[i] + ";" + dialog.plate + "-" + dialog.dimension;
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
                string validity = "ok";
                string code = dialog.siteName + " - Comune di " + dialog.siteLocation + "; Produttore " + dialog.producer + "; CER " + dialog.CER;
                int id = 0;
                string analysis = id.ToString() + ";" + dialog.date + ";" + dialog.CER + ";" + dialog.siteName + ";" + dialog.siteLocation + ";" + dialog.producer + ";;" + validity;

                StreamWriter file = File.AppendText(this.projectPath + "\\Analisi.tg");
                file.WriteLine(analysis);
                file.Close();

                this.LoadAnalysisData();
                this.LinkRegisterAnalysis();
            }
        }

        private void addRegister_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            DnewRegister dialog = new DnewRegister(this.firmData, this.siteData, CER);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int id = 0;
                if (this.registerData.Count > 0)
                {
                    string sid = this.registerData[this.registerData.Count-1].id;
                    if (sid.Contains("bis"))
                    {
                        sid = sid.Replace("bis", "");
                    }
                    id = Convert.ToInt32(sid);
                    id += 1;

                }
                string[] buffer =
                {
                    id.ToString(),
                    dialog.date,
                    dialog.loadUnload,
                    dialog.producer,
                    dialog.carrier,
                    dialog.destination,
                    dialog.carrierPlate,
                    dialog.carrierDimension,
                    dialog.CER,
                    dialog.siteLocation,
                    dialog.siteName
                };
                string register = String.Join(";", buffer);

                StreamWriter file = File.AppendText(this.projectPath + "\\Registro.tg");
                file.WriteLine(register);
                file.Close();

                this.LoadRegisterData();
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
                    string site = dialog.siteLocation + "," + dialog.siteName + ";";

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
                    line = lines[index];

                    line = line.Replace(";", "");
                    line = line + "," + dialog.siteName + ";";
                    lines[index] = line;

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









        private void firmButton_Click(object sender, EventArgs e)
        {
            firmBox.Visible = true;

            siteBox.Visible = false;
            registerBox.Visible = false;
            analysisBox.Visible = false;
            invalidAnalysisBox.Visible = false;
        }

        private void siteButton_Click(object sender, EventArgs e)
        {
            siteBox.Visible = true;

            firmBox.Visible = false;
            registerBox.Visible = false;
            analysisBox.Visible = false;
            invalidAnalysisBox.Visible = false;
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            analysisBox.Visible = true;

            firmBox.Visible = false;
            siteBox.Visible = false;
            registerBox.Visible = false;
            invalidAnalysisBox.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerBox.Visible = true;

            firmBox.Visible = false;
            siteBox.Visible = false;
            analysisBox.Visible = false;
            invalidAnalysisBox.Visible = false;
        }

        private void missingAnalysisButton_Click(object sender, EventArgs e)
        {
            invalidAnalysisBox.Visible = true;

            firmBox.Visible = false;
            siteBox.Visible = false;
            registerBox.Visible = false;
            analysisBox.Visible = false;
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
            Task firm = this.LoadFirmData();
            Task site =  this.LoadSiteData();
            Task register = this.LoadRegisterData();
            Task analysis = this.LoadAnalysisData();

            await firm;
            await site;
            await register;
            await analysis;

            this.LinkRegisterAnalysis();
        }

        private async Task LoadFirmData()
        {
            this.firmBox.Text = "";

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

                this.firmBox.Text += this.firmString(firm);
            }

            this.firmData = firms;
        }

        private async Task LoadSiteData()
        {

            this.siteBox.Text = "";
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
                    string[] names = new string[line.Length-1];
                    for(int j = 0; j < names.Length; j++)
                    {
                        names[j] = line[j+1];
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
                this.siteBox.Text += siteString(site);
            }

            this.siteData = sites;
        }

        private async Task LoadRegisterData()
        {
            //id,date,loadUnload,producer,carrier,destinationFirm,plate,CER,KG,siteLocation,siteName

            this.registerBox.Text = "";

            string[] lines = File.ReadAllLines(projectPath + "\\" + "Registro.tg");

            List<Register> registerList = new List<Register>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "" || lines[i] == " " || lines[i] == null)
                    continue;

                string[] l = lines[i].Split(';');
                Register register;
                if (l.Length >= 11)
                {
                    this.registerBox.Text += l[0] + "\t" + l[1] + "\t" + l[2] + "\t" + l[3] + "\t" + l[4] + "\t" + l[5] + "\t" + l[6] + "\t" + l[7] + "\t" + l[8] + "\t" + l[9] + "\t" + l[10] + "\n";

                    register = new Register(l[0], l[1], l[2], l[3], l[4], l[5], l[6], l[7], l[8], l[9], l[10]);
                    registerList.Add(register);
                }
            }

            this.registerData = registerList;

            Debug.Print("Registro -> Found " + this.registerData.Count + " readable elements");
        }

        private async Task LoadAnalysisData()
        {
            // nro,DATA,CER,CANTIERE,COMUNE,PRODUTTORE,,Validità;

            this.analysisBox.Text = "";

            string[] lines = File.ReadAllLines(projectPath + "\\" + "Analisi.tg");

            List<Analysis> analysisList = new List<Analysis>();
            for(int i = 0; i < lines.Length; i++)
            {
                if(lines[i] == "" || lines[i] == " " || lines[i] == null)
                    continue;

                string[] l = lines[i].Split(';');

                if (l.Length >= 8)
                {
                    if(l[1] == "" && l[2] == "" && l[3] == "")
                        continue;

                    this.analysisBox.Text += l[0] + "\t"+ l[1] + "\t" + l[2] + "\t" + l[3] + "\t" + l[4] + "\t" + l[5] + "\t" + l[7] + "\n";

                    Analysis analysis = new Analysis(l[0], l[1], l[2], l[3], l[4], l[5], l[7]);
                    analysisList.Add(analysis);
                }
            }

            this.analysisData = analysisList;

            Debug.Print("Analisi -> Found " + this.analysisData.Count + " readable elements");
        }

        private async Task LinkRegisterAnalysis()
        {
            // check if the register has a linked analysis
            // same CER, same siteLocation, same siteName, sameProducer
            this.invalidAnalysisBox.Text = "";
            int count = 0;
            for(int i = 0; i < this.registerData.Count; i++)
            {
                Analysis analysis;
                analysis = this.analysisData.Find(x => (
                this.registerData[i].CER.Contains(x.CER) &&
                this.registerData[i].siteLocation.Contains(x.siteLocation) &&
                x.siteName == this.registerData[i].siteName
                ));
                if (analysis != null || this.registerData[i].CER.Contains("170405"))
                {
                    count++;
                }
                else
                {
                    Register l = this.registerData[i];
                    this.invalidAnalysisBox.Text += l.id + "\t" + l.date + "\t" + l.loadUnload + "\t" + l.producer + "\t" + l.carrier + "\t" + l.plate + "\t" + l.CER + "\t" + l.kg + "\t" + l.siteLocation + "\t" + l.siteName + "\n";
                }
            }
        }
    }
}