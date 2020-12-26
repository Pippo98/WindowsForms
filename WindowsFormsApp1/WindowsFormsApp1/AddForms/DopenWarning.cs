using System;
using System.Windows.Forms;

namespace Rifiuti.AddForms
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
