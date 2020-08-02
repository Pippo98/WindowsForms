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
using WindowsFormsApp1.dataClasses;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewSite : Form
    {

        private Site[] siteData;
        private string[] siteNames;
        private string[] siteLocations;

        private bool comboChanged;

        public string siteName;
        public string siteLocation;
        public bool isNewSite;

        public DnewSite(Site[] locations_)
        {
            InitializeComponent();

            this.siteData = locations_;

            if (siteData.Length > 0)
            {
                siteLocations = new string[this.siteData.Length];

                for (int i = 0; i < this.siteData.Length; i++)
                {
                    siteLocations[i] = this.siteData[i].location;
                }
                this.siteCombo.Items.AddRange(siteLocations);
            }
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
                    this.isNewSite = true;
                }
                else
                {
                    this.siteLocation = this.siteCombo.SelectedItem.ToString();
                    this.isNewSite = false;
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
