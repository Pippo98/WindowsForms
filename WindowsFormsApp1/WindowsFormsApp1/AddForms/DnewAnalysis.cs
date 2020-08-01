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
    public partial class DnewAnalysis : Form
    {
        public DnewAnalysis()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            //errorProvider.SetError(nameText, "Aggiungi un nome");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
