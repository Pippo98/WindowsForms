using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Rifiuti.dataClasses;

namespace Rifiuti.EditForms
{
    public partial class DEditFirm : Form
    {
        private List<Firm> firmData;
        private string[] dimensions;

        public Firm oldFirm;
        public Firm newFirm;
        public bool selectedSecondaryItem;
        public Tuple<string, string> secondaryElement;

        public DEditFirm(List<Firm> firms, string[] dimensions)
        {
            InitializeComponent();

            this.firmData = firms;
            this.dimensions = dimensions;

            var names = this.firmData.Select(x => x.name);
            this.NameComboBox.Items.AddRange(names.ToArray());

            this.DimensionCombo.Items.AddRange(this.dimensions);
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "OKButton")
            {
                this.newFirm = new Firm(this.oldFirm.name, new List<Tuple<string, string>>(this.oldFirm.targhe));
                this.newFirm.name = this.NameTextBox.Text;
                Console.WriteLine(this.PlateComboBox.SelectedItem);
                var plate = this.newFirm.targhe.Find(x => x.Item2 == this.PlateComboBox.SelectedItem.ToString());
                var idx = newFirm.targhe.IndexOf(plate);
                plate = Tuple.Create((string)this.DimensionCombo.SelectedItem, this.PlateTextBox.Text);
                newFirm.targhe[idx] = plate;

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

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmb.SelectedItem != null)
            {
                var el = this.firmData.Find(x => x.name == (string)cmb.SelectedItem);
                var plates = el.targhe.Select(x => x.Item2);
                this.oldFirm = el;

                this.PlateComboBox.Items.Clear();
                this.PlateComboBox.Items.AddRange(plates.ToArray());
                this.NameTextBox.Text = (string)cmb.SelectedItem;
            }
        }

        private void PlateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmb.SelectedItem != null)
            {
                var el = this.firmData.Find(x => x.name == (string)this.NameComboBox.SelectedItem);
                var targa = el.targhe.Find(x => x.Item2 == (string)cmb.SelectedItem);
                this.DimensionCombo.SelectedItem = targa.Item1;
                this.readOnlyDimension.Text = targa.Item1;
                this.PlateTextBox.Text = targa.Item2;

                this.secondaryElement = targa;
            }
        }
    }
}
