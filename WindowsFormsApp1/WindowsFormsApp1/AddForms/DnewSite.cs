using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewSite : Form
    {

        private string[] locations;
        private bool comboChanged;

        public string siteName;
        public string siteLocation;

        public DnewSite(string[] locations_)
        {
            InitializeComponent();

            this.locations = locations_;

            if(this.locations.Length > 0 && this.locations[0] != null)
            {
                siteCombo.Items.AddRange(this.locations);
            }

            siteCombo.Items.Add("vjsfdnvfj");
        }




        private void ok_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if(this.nameText.Text == "")
            {
                errorProvider1.SetError(nameText, "Aggiungi un Nome");
                valid = false;
            }
            else
            {
                errorProvider1.Dispose();
            }
            if(comboChanged == false && siteText.Text == "")
            {
                errorProvider2.SetError(siteCombo, "Aggiungi un Comune");
                valid = false;
            }
            else{
                errorProvider2.Dispose();
            }

            if (valid)
            {
                this.siteName = this.nameText.Text;
                if (this.siteText.Text != "")
                {
                    this.siteLocation = this.siteText.Text;
                }
                else
                {
                    this.siteLocation = this.siteCombo.SelectedItem.ToString();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void siteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboChanged = true;
        }
    }
}
