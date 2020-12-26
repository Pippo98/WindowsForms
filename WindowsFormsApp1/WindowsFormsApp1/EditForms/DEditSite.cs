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
    public partial class DEditSite : Form
    {
        List<Site> sites;

        public Site oldSite;
        public Site newSite;
        public bool selectedSecondaryElement;
        public string secondaryElement;

        public DEditSite(List<Site> sites)
        {
            InitializeComponent();

            this.sites = sites;

            string[] locations;
            locations = sites.Select( x => x.location).ToArray();

            this.LocationsComboBox.Items.AddRange(locations);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
               
            if(comboBox.Name == "LocationsComboBox")
            {
                if (comboBox.SelectedIndex != -1)
                {
                    var currentLocation = comboBox.SelectedItem.ToString();
                    var element = this.sites.Find(x => x.location == currentLocation);

                    this.oldSite = element;

                    this.namesComboBox.Items.Clear();
                    var names = element.names.ToArray(); 
                    this.namesComboBox.Items.AddRange(names);

                    this.LocationTextBox.Text = currentLocation;
                }
            }
            else
            {
                if(comboBox.SelectedIndex != -1)
                {
                    var currentName = comboBox.SelectedItem.ToString();

                    selectedSecondaryElement = true;
                    secondaryElement = currentName;

                    this.nameTextBox.Text = currentName;
                }
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);
            Button btn = (Button)sender;

            if (btn.Name == "OKButton")
            {
                newSite = oldSite;
                newSite.location = this.LocationTextBox.Text;
                int idx = this.namesComboBox.SelectedIndex;
                
                newSite.names = oldSite.names;
                if (idx != -1)
                    newSite.names[idx] = this.nameTextBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            if (btn.Name == "DeleteButton")
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            if (btn.Name == "CancelButton")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
