using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dataClasses;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewAnalysis : Form
    {
        private Firm[] firmData;
        private string[] firmNames;

        private string[] CERs;

        private Site[] siteData;
        private string[] siteLocations;
        private string[] siteNames;


        public string date;
        public string CER;
        public string producer;
        public string siteLocation;
        public string siteName;

        public DnewAnalysis(Firm[] firms, Site[] sites, string[] cer)
        {
            InitializeComponent();

            this.firmData = firms;
            this.siteData = sites;
            this.CERs = cer;


            if (firmData.Length > 0)
            {
                firmNames = new string[this.firmData.Length];

                for (int i = 0; i < this.firmData.Length; i++)
                {
                    firmNames[i] = this.firmData[i].name;
                }
                this.producerBox.Items.AddRange(this.firmNames);
            }

            if (siteData.Length > 0)
            {
                siteLocations = new string[this.siteData.Length];

                for (int i = 0; i < this.siteData.Length; i++)
                {
                    siteLocations[i] = this.siteData[i].location;
                }
                this.siteLocationBox.Items.AddRange(siteLocations);
            }

            this.cerBox.Items.AddRange(this.CERs);

        }

        private void updateCurrentSites(string location)
        {
            for (int i = 0; i < this.siteData.Length; i++)
            {
                if (this.siteData[i].location == location)
                {
                    this.siteNames = this.siteData[i].names;
                }
            }
            this.siteNameBox.Items.Clear();
            this.siteNameBox.Items.AddRange(this.siteNames);
        }

        private bool checkIfValid()
        {
            bool valid = true;

            if (this.dateTimePicker.Value == null)
                valid = false;
            if (this.cerBox.SelectedItem == null)
                valid = false;
            if (this.producerBox.SelectedItem == null)
                valid = false;
            if (this.siteLocationBox.SelectedItem == null)
                valid = false;
            if (this.siteNameBox.SelectedItem == null)
                valid = false;

            return valid;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (checkIfValid()) {

                this.date = this.dateTimePicker.Value.ToString();
                this.CER = this.cerBox.SelectedItem.ToString();
                this.producer = this.producerBox.SelectedItem.ToString();
                this.siteLocation = this.siteLocationBox.SelectedItem.ToString();
                this.siteName = this.siteNameBox.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errorProvider.SetError(ok, "Completa tutti i campi");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void siteLocationBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.updateCurrentSites(this.siteLocationBox.SelectedItem.ToString());
        }
    }
}
