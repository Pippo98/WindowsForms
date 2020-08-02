using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewPlate : Form
    {
        public string firm;
        public string plate;
        public string dimension;

        private bool firmBoxChanged;
        private bool dimensionBoxChanged;

        private string[] firmList;
        private string[] dimensionsList;

        public DnewPlate(string[] firms, string[] dimesions)
        {
            InitializeComponent();

            this.firmList = firms;
            this.dimensionsList = dimesions;

            if (this.firmList.Length > 0)
            {
                this.firmBox.Items.AddRange(this.firmList);
            }

            if (this.dimensionsList.Length > 0)
            {
                this.dimensionBox.Items.AddRange(this.dimensionsList);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (!firmBoxChanged)
            {
                errorProvider1.SetError(this.firmBox, "Seleziona Impresa");
                valid = false;
            }
            else
            {
                errorProvider1.Dispose();
            }
            if (this.plateText.Text == "" || !this.dimensionBoxChanged)
            {
                errorProvider2.SetError(this.plateText, "Inserisci Targa e Dimensione");
                valid = false;
            }
            else
            {
                errorProvider2.Dispose();
            }

            if (valid)
            {
                this.firm = this.firmBox.SelectedItem.ToString();
                this.plate = this.plateText.Text;
                this.dimension = this.dimensionBox.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void firmBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.firmBoxChanged = true;
        }

        private void dimensionBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.dimensionBoxChanged = true;
        }
    }
}
