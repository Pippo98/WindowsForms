using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rifiuti.EditForms
{
    public partial class DEditCERs : Form
    {
        public List<int> CERs;
        public DEditCERs(List<int> CERs)
        {
            InitializeComponent();

            this.CERs = CERs;
            updateValues();
        }

        private void updateValues()
        {
            this.CERComboBox.Items.Clear();
            this.CERList.Items.Clear();

            var values = Array.ConvertAll(this.CERs.ToArray(), x => x.ToString());
            this.CERComboBox.Items.AddRange(values);
            this.CERList.Items.AddRange(values);
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "addButton")
            {
                this.CERs.Add(int.Parse(this.NewTextBox.Text));
                updateValues();
            }
            else if (btn.Name == "updateButton") {
                if (this.CERComboBox.SelectedIndex == -1)
                    return;

                if(this.CERTextBox.Text == "")
                {
                    this.CERs.RemoveAt(this.CERComboBox.SelectedIndex);
                }
                else
                {
                    var idx = this.CERs.IndexOf(int.Parse(this.CERComboBox.SelectedItem.ToString()));
                    this.CERs[idx] = int.Parse(this.CERTextBox.Text);
                }

                updateValues();
            }
            else if (btn.Name == "OKButton")
            {
                if (this.CERComboBox.SelectedIndex != -1)
                {
                    var idx = this.CERs.IndexOf(int.Parse(this.CERComboBox.SelectedItem.ToString()));
                    this.CERs[idx] = int.Parse(this.CERTextBox.Text);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (btn.Name == "cancelButton")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void CERComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CERComboBox.SelectedIndex == -1)
                return;

            this.CERTextBox.Text = this.CERComboBox.SelectedItem.ToString();
        }

        private void CERTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
