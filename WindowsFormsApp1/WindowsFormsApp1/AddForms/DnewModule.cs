﻿using Org.BouncyCastle.Asn1.Esf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dataClasses;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewModule : Form
    {
        private List<Firm>      firmData;
        private string[]    firmNames;
        private Tuple<string, string>[] platesTuple;
        private string[]    plates;
        private string[]    platesDimension;

        private string[]    CERs;

        private List<Site>      siteData;
        private string[]        siteLocations;
        private string[]        siteNames;
        private string          moduleType;

        public string note;
        public string date;
        public string loadUnload;
        public string producer;
        public string carrier;
        public string destination;
        public string carrierPlate;
        public string carrierDimension;
        public string CER;
        public bool toBreak;
        public int Kg;
        public string siteLocation;
        public string siteName;


        public DnewModule(List<Firm> firms, List<Site> sites, string[] cer, string moduleType)
        {
            InitializeComponent();

            this.firmData = firms;
            this.siteData = sites;
            this.CERs = cer;
            this.moduleType = moduleType;


            if (firmData.Count > 0)
            {
                firmNames = new string[this.firmData.Count];

                for (int i = 0; i < this.firmData.Count; i++)
                {
                    if (this.firmData[i] == null)
                    {
                        continue;
                    }
                    firmNames[i] = this.firmData[i].name;
                }
                this.producerBox.Items.AddRange(this.firmNames);
                this.carrierBox.Items.AddRange(this.firmNames);
                this.destinationBox.Items.AddRange(this.firmNames);
            }

            if (siteData.Count > 0)
            {
                siteLocations = new string[this.siteData.Count];

                for(int i = 0; i < this.siteData.Count; i++)
                {
                    siteLocations[i] = this.siteData[i].location;
                }
                this.siteLocationBox.Items.AddRange(siteLocations);
            }

            this.cerBox.Items.AddRange(this.CERs);
            this.loadUnloadBox.Items.Add("Carico");
            this.loadUnloadBox.Items.Add("Scarico");
            this.loadUnloadBox.SelectedIndex = 0;
        }

        private void updateCurrentPlates(string firm)
        {
            for (int i = 0; i < this.firmData.Count; i++)
            {
                if(this.firmData[i].name == firm)
                {
                    this.platesTuple = new Tuple<string, string>[this.firmData[i].targhe.Count];
                    for (int j = 0; j < this.platesTuple.Length; j++)
                    {
                        this.platesTuple[j] = this.firmData[i].targhe[j];
                    }
                    
                    this.plates = new string[this.platesTuple.Length];
                    this.platesDimension = new string[this.platesTuple.Length];
                    for (int j = 0; j < this.firmData[i].targhe.Count; j++)
                    {
                        this.plates[j] = this.firmData[i].targhe[j].Item2;
                        this.platesDimension[j] = this.firmData[i].targhe[j].Item1;
                    }
                    break;
                }
            }
            this.plateBox.Items.Clear();
            this.plateBox.Items.AddRange(this.plates);
        }

        private void updateCurrentSites(string location)
        {
            for (int i =0; i < this.siteData.Count; i++)
            {
                if(this.siteData[i].location == location)
                {
                    this.siteNames = this.siteData[i].names;
                }
            }
            this.siteNameBox.Items.Clear();
            this.siteNameBox.Items.AddRange(this.siteNames);
        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void ok_Click(object sender, EventArgs e)
        {
            if (checkIfValid())
            {
                this.note = this.noteBox.Text;
                this.date = this.dateTimePicker.Value.ToString();
                this.producer = this.producerBox.SelectedItem.ToString();
                this.carrier = this.carrierBox.SelectedItem.ToString();
                if(this.moduleType == "Implant")
                    this.carrierPlate = this.plates[this.plateBox.SelectedIndex];
                this.loadUnload = this.loadUnloadBox.SelectedItem.ToString();
                this.CER = this.cerBox.SelectedItem.ToString();
                this.toBreak = this.toBreakCheck.Checked;
                this.Kg = int.Parse(this.KgBox.Text);
                this.siteLocation = this.siteLocationBox.SelectedItem.ToString();
                this.siteName = this.siteNameBox.SelectedItem.ToString();

                if(loadUnloadBox.SelectedItem.ToString() == "Scarico")
                {
                    this.destination = this.destinationBox.SelectedItem.ToString();
                }
                else
                {
                    this.destination = "";
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.errorProvider1.SetError(this.ok, "Completa tutti i campi");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------//

        private void producerBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.carrierBox.SelectedItem = this.producerBox.SelectedItem;
        }

        private void carrierBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.updateCurrentPlates(this.carrierBox.SelectedItem.ToString());
        }

        private void siteLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCurrentSites(siteLocationBox.SelectedItem.ToString());
        }

        private bool checkIfValid()
        {
            bool valid = true;

            if(this.dateTimePicker.Value == null)
                valid = false;
            if(this.producerBox.SelectedItem == null)
                valid = false;
            if(this.carrierBox.SelectedItem == null)
                valid = false;
            if (this.plateBox.SelectedItem == null && this.moduleType == "Implant")
                valid = false;
            if (this.loadUnloadBox.SelectedItem == null)
                valid = false;
            if (this.cerBox.SelectedItem == null)
                valid = false;
            if (this.siteLocationBox.SelectedItem == null)
                valid = false;
            if (this.siteNameBox.SelectedItem == null)
                valid = false;
            if (this.KgBox.Text == "")
                valid = false;
            if (this.loadUnloadBox.SelectedItem != null && this.loadUnloadBox.SelectedItem.ToString() == "Scarico")
                if (this.destinationBox.SelectedItem == null)
                    valid = false;

            return valid;
        }

        private void loadUnloadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loadUnloadBox.SelectedItem != null)
            {
                if(loadUnloadBox.SelectedItem.ToString() == "Scarico")
                    this.destinationBox.Enabled = true;
                else
                    this.destinationBox.Enabled = false;
            }
        }

        private void KgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}