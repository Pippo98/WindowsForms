using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.NewFolder1
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
                this.comboBox.SelectedIndex = 0;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.name = nameText.Text;
            this.targa = this.plateText.Text;
            this.dimension = this.comboBox.SelectedItem.ToString();
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
