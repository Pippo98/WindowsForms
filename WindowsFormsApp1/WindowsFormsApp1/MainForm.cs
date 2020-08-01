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
        private string[] SITEs;

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

            SITEs = new string[1];

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

        private void newPrjBtn_Click(object sender, EventArgs e)
        {
            DnewProject dialog = new DnewProject();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.projectPath = this.basePath + "\\" + dialog.name;
                string[] Filenames =
                {
                    "Imprese",
                    "Cantieri",
                    "Comuni",
                    "Targhe"
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
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Debug.Print(dialog.projectPath);
                Debug.Print(dialog.projectName);

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

        private void addImpresa_MouseClick(object sender, MouseEventArgs e)
        {
            // Show dialog to add firm
            aggiungiImpresa firm = new aggiungiImpresa();
            // Show dialog as a modal dialog and determine if DialogResult = OK.
            if (firm.ShowDialog(this) == DialogResult.OK)
            {
                string impresa = firm.name + "," + firm.targa + "-" + firm.dimension + ";\n";

                FileStream fil1 = File.Open(this.projectPath + "\\Imprese.tg", FileMode.Open);
                UTF8Encoding temp = new UTF8Encoding(true);

                byte[] b = temp.GetBytes(impresa);
                fil1.Position = fil1.Length;
                fil1.Write(b, 0, b.Length);
                fil1.Close();

                this.loadFirmData();
            }
            else
            {
                Debug.Print("Canceled");
            }
            firm.Dispose();
        }

        private void addPlate_Click(object sender, EventArgs e)
        {
            DnewPlate dialog = new DnewPlate(this.firmNames, this.dimensions);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string impresa = dialog.firm + "," + dialog.plate + "-" + dialog.dimension + ";\n";

                Debug.Print(impresa);
            }
        }

        private void addAnalysis_Click(object sender, EventArgs e)
        {
            DnewAnalysis dialog = new DnewAnalysis();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void addTransaction_Click(object sender, EventArgs e)
        {
            DnewTransaction dialog = new DnewTransaction();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void addSite_Click(object sender, EventArgs e)
        {
            // Show dialog to add Building Site
            DnewSite dialog = new DnewSite(this.SITEs);
            // Show dialog as a modal dialog and determine if DialogResult = OK.
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string site = dialog.siteLocation + "," + dialog.siteName + ";\n";

                FileStream fil = File.Open(this.projectPath + "\\Cantieri.tg", FileMode.Open);
                UTF8Encoding temp = new UTF8Encoding(true);

                byte[] b = temp.GetBytes(site);
                fil.Position = fil.Length;
                fil.Write(b, 0, b.Length);
                fil.Close();

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
            string text = "";

            UTF8Encoding temp = new UTF8Encoding(true);
            FileStream firmFile = File.Open(projectPath + "\\" + "Imprese.tg", FileMode.Open);
            byte[] b = new byte[1024];

            while(firmFile.Read(b, 0, b.Length) > 0)
            {
                text += temp.GetString(b);
            }

            this.textBox.Text = text;
            firmFile.Close();

            string[] lines = text.Split('\n');

            Firm[] firms = new Firm[lines.Length];
            this.firmNames = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(';', ' ');
                string[] data = lines[i].Split(',');

                string name = data[0];
                this.firmNames[i] = name;

                Tuple<string, string>[] plates = new Tuple<string, string>[data.Length];
                for (int j = 1; j < data.Length; j++)
                {
                    Tuple<string, string> plate = Tuple.Create(data[j].Split('-')[0], data[j].Split('-')[1]);
                    plates[j] = plate;
                }

                Firm firm = new Firm(name, plates);
                firms[i] = firm;
            }

            this.firmData = firms;

            return 0;
        }

        private int loadSiteData()
        {
            string text = "";

            UTF8Encoding temp = new UTF8Encoding(true);
            FileStream siteFile = File.Open(projectPath + "\\" + "Cantieri.tg", FileMode.Open);
            byte[] b = new byte[1024];

            while (siteFile.Read(b, 0, b.Length) > 0)
            {
                text += temp.GetString(b);
            }

            Debug.Print(text);
            siteFile.Close();

            string[] lines = text.Split('\n');

            Site[] sites = new Site[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(';', ' ');
                string[] line = lines[i].Split(',');
                Debug.Print(lines[i]);
                if (line.Length > 1)
                {
                    Site site = new Site(line[0], line[1]);
                    sites[i] = site;
                }
            }

            this.siteData = sites;

            return 0;
        }
    }
}
