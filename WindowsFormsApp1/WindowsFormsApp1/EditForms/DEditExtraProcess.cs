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
    public partial class DEditExtraProcess : Form
    {
        public List<ExtraProcessing> processes;
        private List<int> CER;

        string[] options;

        public DEditExtraProcess(List<ExtraProcessing> processes, List<int> CERs)
        {
            InitializeComponent();

            this.processes = processes;
            this.CER = CERs;

            this.options = new string[]
            {
                "vagliato",
                "frantumato"
            };

            updateValues();
        }

        private void updateValues()
        {
            this.ProcessList.Items.Clear();
            this.editComboBox.Items.Clear();
            this.newTypeComboBox.Items.Clear();
            this.editTypeComboBox.Items.Clear();
            this.cerCombo.Items.Clear();
            this.editCERCombo.Items.Clear();

            List<string> items = new List<string>();
            foreach (var e in this.processes)
                items.Add(e.getString(" "));

            this.newTypeComboBox.Items.AddRange(this.options);
            this.editTypeComboBox.Items.AddRange(this.options);

            this.ProcessList.Items.AddRange(items.ToArray());
            this.editComboBox.Items.AddRange(items.ToArray());

            this.cerCombo.Items.AddRange(Array.ConvertAll(this.CER.ToArray(), x => x.ToString()));
            this.editCERCombo.Items.AddRange(Array.ConvertAll(this.CER.ToArray(), x => x.ToString()));

            this.newTypeComboBox.Text = "";
            this.editTypeComboBox.Text = "";
            this.editComboBox.Text = "";
            this.kgBox.Text = "";
            this.editCERCombo.Text = "";
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "addButton")
            {
                if(this.newTypeComboBox.SelectedIndex == -1)
                    return;

                this.processes.Add(new 
                    ExtraProcessing(
                    this.datePicker.Value, 
                    int.Parse(this.cerCombo.SelectedItem.ToString()),
                    int.Parse(this.kgBox.Text),
                    this.newTypeComboBox.SelectedItem.ToString()
                    ));

                updateValues();
            }
            else if (btn.Name == "updateButton")
            {
                if (this.editComboBox.SelectedIndex == -1)
                    return;
                if (this.editTypeComboBox.SelectedIndex == -1)
                    return;

                this.processes[this.editComboBox.SelectedIndex].type = this.editDatePicker.Value.ToString("d");
                this.processes[this.editComboBox.SelectedIndex].CER = int.Parse(this.editCERCombo.SelectedItem.ToString());
                this.processes[this.editComboBox.SelectedIndex].quantity = int.Parse(this.editKgBox.Text);
                this.processes[this.editComboBox.SelectedIndex].type = this.editTypeComboBox.SelectedItem.ToString();

                updateValues();
            }
            else if (btn.Name == "deleteButton")
            {
                if (this.editComboBox.SelectedIndex == -1)
                    return;
                if (this.editTypeComboBox.SelectedIndex == -1)
                    return;

                this.processes.RemoveAt(this.editComboBox.SelectedIndex);

                updateValues();
            }
            else if (btn.Name == "OKButton")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (btn.Name == "cancelButton")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void comboChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if(cmb.Name == "newTypeComboBox")
            {

            }
            else if(cmb.Name == "editComboBox")
            {
                if (cmb.SelectedIndex == -1)
                    return;

                var currentProc = this.processes[cmb.SelectedIndex];

                this.editDatePicker.Value = currentProc.date;
                this.editTypeComboBox.SelectedItem = currentProc.type;

            }
        }


        private void kgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
