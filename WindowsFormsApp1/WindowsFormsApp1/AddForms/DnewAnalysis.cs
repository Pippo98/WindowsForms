﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rifiuti.dataClasses;

namespace Rifiuti.AddForms
{
    public partial class DnewAnalysis : Form
    {
        private List<Firm> firmData;
        private string[] firmNames;

        private List<int> CERs;

        private List<Site> siteData;
        private string[] siteLocations;
        private string[] siteNames;


        public DateTime date;
        public string CER;
        public string producer;
        public string siteLocation;
        public string siteName;
        public string validity;

        public DnewAnalysis(List<Firm> firms, List<Site> sites, List<int> cer)
        {
            InitializeComponent();

            this.firmData = firms;
            this.siteData = sites;
            this.CERs = cer;


            if (firmData.Count > 0)
            {
                firmNames = new string[this.firmData.Count];

                for (int i = 0; i < this.firmData.Count; i++)
                {
                    firmNames[i] = this.firmData[i].name;
                }
                this.producerBox.Items.AddRange(this.firmNames);
            }

            if (siteData.Count > 0)
            {
                siteLocations = new string[this.siteData.Count];

                for (int i = 0; i < this.siteData.Count; i++)
                {
                    siteLocations[i] = this.siteData[i].location;
                }
                this.siteLocationBox.Items.AddRange(siteLocations);
            }

            this.cerBox.Items.AddRange(Array.ConvertAll(this.CERs.ToArray(), x => x.ToString()));

        }

        private void updateCurrentSites(string location)
        {
            for (int i = 0; i < this.siteData.Count; i++)
            {
                if (this.siteData[i].location == location)
                {
                    this.siteNames = this.siteData[i].names.ToArray();
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
            if (checkIfValid())
            {

                this.date = this.dateTimePicker.Value;
                this.CER = this.cerBox.SelectedItem.ToString();
                this.producer = this.producerBox.SelectedItem.ToString();
                this.siteLocation = this.siteLocationBox.SelectedItem.ToString();
                this.siteName = this.siteNameBox.SelectedItem.ToString();
                this.validity = "ok";
                if (DateTime.Compare(this.date.AddYears(1), DateTime.Now) < 0)
                    this.validity = "scaduta";

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
