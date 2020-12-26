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

        string[] options;

        public DEditExtraProcess(List<ExtraProcessing> processes)
        {
            InitializeComponent();

            this.processes = processes;

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
            this.newTypeComboBox.Items.Clear();

            List<string> items = new List<string>();
            foreach (var e in this.processes)
                items.Add(e.getString(" "));

            this.newTypeComboBox.Items.AddRange(this.options);
            this.ProcessList.Items.AddRange(items.ToArray());
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
                    this.newTypeComboBox.SelectedItem.ToString()
                    ));
            }
            else if (btn.Name == "updateButton")
            {
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
        }
    }
}
