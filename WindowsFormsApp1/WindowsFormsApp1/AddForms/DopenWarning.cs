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
    public partial class DopenWarning : Form
    {
        public string newPath;

        private string basePath;
        public DopenWarning(string path)
        {
            InitializeComponent();

            this.basePath = path;
        }

        private void openButton_Click(object sender, EventArgs e)
        {

            DopenProject open = new DopenProject(this.basePath);
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.newPath = open.projectPath;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
