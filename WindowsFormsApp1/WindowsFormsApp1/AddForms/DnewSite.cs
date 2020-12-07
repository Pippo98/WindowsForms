using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.dataClasses;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewSite : Form
    {

        private List<Site> siteData;
        private string[] siteNames;
        private string[] siteLocations;

        private bool comboChanged;

        public string siteName;
        public string siteLocation;
        public bool isNewSite;

        public DnewSite(List<Site> locations_)
        {
            InitializeComponent();

            this.siteData = locations_;

            if (siteData.Count > 0)
            {
                siteLocations = new string[this.siteData.Count];

                for (int i = 0; i < this.siteData.Count; i++)
                {
                    siteLocations[i] = this.siteData[i].location;
                }
                this.siteCombo.Items.AddRange(siteLocations);
            }
        }


        private void ok_Click(object sender, EventArgs e)
        {
            bool valid = true;
            this.isNewSite = true;

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
                    if(this.siteCombo.SelectedIndex != -1)
                    {
                        this.siteLocation = this.siteCombo.SelectedItem.ToString();
                        this.isNewSite = false;
                    }
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
