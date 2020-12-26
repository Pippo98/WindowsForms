using System;
using System.Windows.Forms;

namespace Rifiuti.AddForms
{
    public partial class aggiungiImpresa : Form
    {
        public string name;
        public string targa;
        public string dimension;

        private string[] dimVeichle;
        public aggiungiImpresa()
        {
            InitializeComponent();

            dimVeichle = new string[5] {
                "Camioncino",
                "2 assi",
                "3 assi",
                "4 assi",
                "Bilico"
            };
            for (int i = 0; i < dimVeichle.Length; i++)
            {
                this.comboBox.Items.Add(this.dimVeichle[i]);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.name = nameText.Text;
            this.targa = this.plateText.Text;
            if(this.comboBox.SelectedIndex != -1)
            {
                this.dimension = this.comboBox.SelectedItem.ToString();
            }
            else
            {
                this.dimension = "";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
