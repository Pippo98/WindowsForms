using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rifiuti.dataClasses;

namespace Rifiuti.EditForms
{
    public partial class DEditModule : Form
    {
        Module currentForm;
        public List<Module> implant;
        public List<Module> various;

        private List<Firm> firmData;
        private List<string> firmNames;
        private Tuple<string, string>[] platesTuple;
        private string[] plates;
        private string[] platesDimension;


        private List<int> CERs;
        private List<Site> siteData;
        private List<string> siteLocations;
        private string[] siteNames;
        private string moduleType;

        public DEditModule(List<Module> implant, List<Module> various, List<Firm> firms, List<Site> sites, List<int> cer, string[] dimensions)
        {
            InitializeComponent();

            this.implant = implant;
            this.various = various;
            this.firmData = firms;
            this.siteData = sites;
            this.CERs = cer;

            var ids = this.implant.Select(x => (object)x.id).ToArray();
            this.IDBox.Items.AddRange(ids);

            if (firmData.Count > 0)
            {
                firmNames = new List<string>();


                foreach (var el in this.firmData)
                {
                    if (el != null)
                        firmNames.Add(el.name);
                }
                this.producerBox.Items.AddRange(this.firmNames.ToArray());
                this.carrierBox.Items.AddRange(this.firmNames.ToArray());
                this.destinationBox.Items.AddRange(this.firmNames.ToArray());
                this.dimensionBox.Items.AddRange(dimensions);
            }

            if (siteData.Count > 0)
            {
                siteLocations = new List<string>();

                foreach (var el in this.siteData)
                {
                    siteLocations.Add(el.location);
                }
                this.siteLocationBox.Items.AddRange(siteLocations.ToArray());
            }

            this.cerBox.Items.AddRange(Array.ConvertAll(this.CERs.ToArray(), x => x.ToString()));
            this.loadUnloadBox.Items.Add("Carico");
            this.loadUnloadBox.Items.Add("Scarico");
            this.loadUnloadBox.SelectedIndex = 0;
        }

        public void updateValues()
        {
            this.dimensionBox.SelectedIndex = -1;

            this.dateText.Text = this.currentForm.date.ToString("d");
            this.producerText.Text = this.currentForm.producer.ToString();
            this.carrierText.Text = this.currentForm.carrier.ToString();
            this.plateText.Text = this.currentForm.plate.ToString();
            this.dimensionText.Text = this.currentForm.dimension.ToString();
            this.loadUnloadText.Text = this.currentForm.loadUnload.ToString();
            this.destinationText.Text = this.currentForm.destination.ToString();
            this.CERText.Text = this.currentForm.CER.ToString();
            this.siteText.Text = this.currentForm.siteLocation.ToString();
            this.siteNameText.Text = this.currentForm.siteName.ToString();
            this.KgText.Text = this.currentForm.kg.ToString();
            this.otherText.Text = this.currentForm.toBreak.ToString();
            this.noteText.Text = this.currentForm.note.ToString();
            this.toProducerText.Text = this.currentForm.assignToProducer.ToString();

            this.dateTimePicker.Value = this.currentForm.date;
            this.producerBox.SelectedItem = this.currentForm.producer;
            this.carrierBox.SelectedItem = this.currentForm.carrier;
            this.plateBox.SelectedItem = this.currentForm.plate;
            this.dimensionBox.SelectedItem = this.currentForm.dimension;
            this.loadUnloadBox.SelectedItem = this.currentForm.loadUnload;
            this.destinationBox.SelectedItem = this.currentForm.destination;
            this.cerBox.SelectedItem = this.currentForm.CER.ToString();
            this.siteLocationBox.SelectedItem = this.currentForm.siteLocation;
            this.siteNameBox.SelectedItem = this.currentForm.siteName;
            this.KgBox.Text = this.currentForm.kg.ToString();
            this.noteBox.Text = this.currentForm.note;
            this.toProducerBox.Text = this.currentForm.assignToProducer;

            this.toBreakCheckBox.Checked = false;
            this.asphaltCheckBox.Checked = false;

            if (this.currentForm.toBreak == "p")
                this.toBreakCheckBox.Checked = true;
            else if (this.currentForm.toBreak == "a")
                this.asphaltCheckBox.Checked = true;

        }

        private void updateCurrentPlates(string firm)
        {
            for (int i = 0; i < this.firmData.Count; i++)
            {
                if (this.firmData[i].name == firm)
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

        private void buttonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn.Name == "OKButton")
            {
                int idx = 0;
                if (this.isImplant.Checked)
                    idx = this.implant.IndexOf(this.currentForm);
                else
                    idx = this.various.IndexOf(this.currentForm);

                this.currentForm.note = this.noteBox.Text;
                this.currentForm.date = this.dateTimePicker.Value;
                this.currentForm.producer = this.producerBox.SelectedItem.ToString();
                this.currentForm.carrier = this.carrierBox.SelectedItem.ToString();
                this.currentForm.plate = this.plates[this.plateBox.SelectedIndex];
                this.currentForm.loadUnload = this.loadUnloadBox.SelectedItem.ToString();
                this.currentForm.CER = int.Parse(this.cerBox.SelectedItem.ToString());
                if (this.toBreakCheckBox.Checked == true)
                    this.currentForm.toBreak = "p";
                else if (this.asphaltCheckBox.Checked == true)
                    this.currentForm.toBreak = "a";
                else
                    this.currentForm.toBreak = "";

                this.currentForm.kg = int.Parse(this.KgBox.Text);
                this.currentForm.siteLocation = this.siteLocationBox.SelectedItem.ToString();
                this.currentForm.siteName = this.siteNameBox.SelectedItem.ToString();
                this.currentForm.assignToProducer = this.toProducerBox.Text;

                if (loadUnloadBox.SelectedItem.ToString() == "Scarico")
                {
                    this.currentForm.destination = this.destinationBox.SelectedItem.ToString();
                }
                else
                {
                    this.currentForm.destination = "";
                }

                if (this.isImplant.Checked)
                    this.implant[idx] = this.currentForm;
                else
                    this.various[idx] = this.currentForm;


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (btn.Name == "deleteButton")
            {
                this.implant.Remove(this.currentForm);
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else if(btn.Name == "cancelButton")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        private void IDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IDBox.SelectedIndex == -1)
                return;

            if(this.isImplant.Checked)
                this.currentForm = this.implant.Find(x => x.id == (int)this.IDBox.SelectedItem);
            else
                this.currentForm = this.various.Find(x => x.id == (int)this.IDBox.SelectedItem);

            if (this.currentForm == null)
                return;

            updateValues();
        }

        private void radioChanged(object sender, EventArgs e)
        {
            this.IDBox.Items.Clear();
            if (this.isImplant.Checked)
            {
                var ids = this.implant.Select(x => (object)x.id).ToArray();
                this.IDBox.Items.AddRange(ids);
            }
            else
            {
                var ids = this.various.Select(x => (object)x.id).ToArray();
                this.IDBox.Items.AddRange(ids);
            }

        }

        private void producerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.carrierBox.SelectedItem = this.producerBox.SelectedItem;
        }

        private void carrierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateCurrentPlates(this.carrierBox.SelectedItem.ToString());
        }

        private void siteLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCurrentSites(siteLocationBox.SelectedItem.ToString());
        }

        private void loadUnloadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadUnloadBox.SelectedItem != null)
            {
                if (loadUnloadBox.SelectedItem.ToString() == "Scarico")
                    this.destinationBox.Enabled = true;
                else
                    this.destinationBox.Enabled = false;
            }
        }

        private void KgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void asphaltCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.asphaltCheckBox.Checked)
                this.toBreakCheckBox.Checked = false;
        }

        private void toBreakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.toBreakCheckBox.Checked)
                this.asphaltCheckBox.Checked = false;
        }
    }
}
