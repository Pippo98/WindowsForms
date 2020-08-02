using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AddForms
{
    public partial class DopenProject : Form
    {

        string basePath;
        public string projectPath;
        public string projectName;
        string[] projects;
        public DopenProject(string basePath_)
        {
            InitializeComponent();

            this.basePath = basePath_;

            this.updatePrjList();
        }

        private void updatePrjList()
        {
            this.prjList.Items.Clear();
            string[] dirs = System.IO.Directory.GetDirectories(this.basePath);
            this.projects = new string[dirs.Length];
            for (int i = 0; i < dirs.Length; i++)
            {
                string dir = dirs[i].Replace(this.basePath + "\\", "");
                this.projects.Append(dir);
                prjList.Items.Add(dir);
            }
        }

        private void prjList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (prjList.SelectedItems.Count == 1)
            {
                System.Diagnostics.Debug.Print(prjList.SelectedItems[0].Text);
            }
        }

        private void prjList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (prjList.SelectedItems.Count == 1)
            {
                this.projectName = prjList.SelectedItems[0].Text;
                this.projectPath = this.basePath + "\\" + this.projectName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void newPrjBtn_Click(object sender, EventArgs e)
        {
            DnewProject dialog = new DnewProject();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.projectPath = this.basePath + "\\" + dialog.name;

                if(this.checkAndCreatePath(this.projectPath) == 0)
                {
                    // Project does already exist
                }

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
                    System.Diagnostics.Debug.Print(path);

                    System.IO.FileStream fil1 = System.IO.File.Open(path, System.IO.FileMode.CreateNew);
                    fil1.Close();
                }
            }

            this.updatePrjList();
        }

        private int checkAndCreatePath(string path)
        {

            int ret = 0;

            string[] dirs = path.Split('\\');
            string tempPath = "";
            for (int j = 0; j < dirs.Length; j++)
            {
                tempPath += dirs[j] + "\\";
                if (!System.IO.Directory.Exists(tempPath))
                {
                    System.IO.Directory.CreateDirectory(tempPath);
                    ret = 1;
                }
            }

            return ret;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (prjList.SelectedItems.Count > 0)
            {
                this.projectName = prjList.SelectedItems[0].Text;
                this.projectPath = this.basePath + "\\" +  this.projectName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errorProvider.SetError(readOnlyTextBox1, "Seleziona un progetto");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
