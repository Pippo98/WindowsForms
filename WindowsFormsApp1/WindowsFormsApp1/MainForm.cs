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
using WindowsFormsApp1.AddForms;
using WindowsFormsApp1.dataClasses;
using WindowsFormsApp1.NewFolder1;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private string      basePath;
        private string      projectPath;

        private bool isProjectOpen;

        private string[] CER;

        private Firm[] firmData;
        private Site[] siteData;

        private string[] dimensions;
        private string[] firmNames;

        public MainForm()
        {
            InitializeComponent();

            this.initializeVariables();

            this.checkAndCreatePath(this.basePath);

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

        private void openTool_Click(object sender, EventArgs e)
        {
            DopenProject dialog = new DopenProject(this.basePath);
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Debug.Print("Opened project " + dialog.projectName + " Located at: " + dialog.projectPath);

                this.projectPath = dialog.projectPath;

                this.isProjectOpen = true;

                OnProjectOpened();
            }
        }

        private void OnProjectOpened()
        {
            this.loadAllData();
        }

        private void loadAllData()
        {
            this.loadFirmData();
            this.loadSiteData();
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

        private void addImpresa_MouseClick(object sender, MouseEventArgs e)
        {

            if (!checkIfOpen())
                return;

            // Show dialog to add firm
            aggiungiImpresa dialog = new aggiungiImpresa();
            // Show dialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string firm = dialog.name + "," + dialog.targa + "-" + dialog.dimension + ";\n";

                StreamWriter file = File.AppendText(this.projectPath + "\\Imprese.tg");
                file.WriteLine(firm);
                file.Close();

                this.loadFirmData();
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
                        lines[i] = lines[i].Replace(";", "");
                        lines[i] = lines[i] + "," + dialog.plate + "-" + dialog.dimension + ";";
                        break;
                    }
                }

                File.WriteAllLines(this.projectPath + "\\Imprese.tg", lines);

                this.loadFirmData();
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
                int id = 0;
                string analysis = id.ToString() + "," + dialog.date + "," + dialog.CER + "," + dialog.siteName + "," + dialog.siteLocation + "," + dialog.producer + "," + code;

                StreamWriter file = File.AppendText(this.projectPath + "\\Analisi.tg");
                file.WriteLine(analysis);
                file.Close();
                //Analysis analysis = new Analysis(0, dialog.date, dialog.CER, dialog.siteName, dialog.siteLocation, dialog.producer, code);
            }
        }

        private void addRegister_Click(object sender, EventArgs e)
        {
            if (!checkIfOpen())
                return;

            DnewRegister dialog = new DnewRegister(this.firmData, this.siteData, CER);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] buffer =
                {
                    dialog.date,
                    dialog.loadUnload,
                    dialog.producer,
                    dialog.carrier,
                    dialog.carrierPlate,
                    dialog.carrierDimension,
                    dialog.CER,
                    dialog.siteLocation,
                    dialog.siteName
                };
                string register = String.Join(",", buffer);

                Debug.Print(register);

                StreamWriter file = File.AppendText(this.projectPath + "\\Registro.tg");
                file.WriteLine(register);
                file.Close();
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
                    string site = dialog.siteLocation + "," + dialog.siteName + ";\n";

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

                this.loadSiteData();
            }
            else
            {
                Debug.Print("Canceled");
            }
            dialog.Dispose();
        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private int loadFirmData()
        {
            string[] lines = File.ReadAllLines(projectPath + "\\" + "Imprese.tg");

            Firm[] firms = new Firm[lines.Length];
            this.firmNames = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(';', ' ');
                string[] data = lines[i].Split(',');

                string name = data[0];
                this.firmNames[i] = name;

                var plates = new List<Tuple<string, string>>();
                for (int j = 1; j < data.Length; j++)
                {
                    Tuple<string, string> plate = Tuple.Create(data[j].Split('-')[0], data[j].Split('-')[1]);
                    plates.Add(plate);
                }

                Firm firm = new Firm(name, plates);
                firms[i] = firm;
            }

            this.firmData = firms;

            return 0;
        }

        private int loadSiteData()
        {

            string[] lines = File.ReadAllLines(projectPath + "\\" + "Cantieri.tg");

            Site[] sites = new Site[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Debug.Print("siteLine: " + lines[i] + lines[i].Length.ToString());
                if (lines[i] == "" || lines[i] == " " || lines[i] == null)
                {
                    Debug.Print("wrongline");
                    continue;
                }
                lines[i] = lines[i].Replace(';', ' ');


                string[] line = lines[i].Split(',');
                if (line.Length > 1)
                {
                    string location = line[0];
                    string[] names = new string[line.Length-1];
                    for(int j = 0; j < names.Length; j++)
                    {
                        names[j] = line[j+1];
                    }
                    Site site = new Site(location, names);
                    sites[i] = site;
                }
            }

            this.siteData = sites;

            return 0;
        }
    }
}
