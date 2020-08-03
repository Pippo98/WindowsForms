using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Print
{
    public partial class DselectPrint : Form
    {

        private string[] options;

        public string[] selected;

        public DselectPrint(string[] options_)
        {
            InitializeComponent();


            this.options = new string[options_.Length + 1];
            this.options[0] = "Seleziona Tutti";
            for (int i = 1; i < this.options.Length; i++)
            {
                this.options[i] = options_[i-1];
            }

            this.optionsList.Items.AddRange(this.options);

            this.selected = new string[options.Length];
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.selected = new string[this.optionsList.CheckedItems.Count];
            for (int i = 0; i < this.optionsList.CheckedItems.Count; i++)
            {
                selected[i] = this.optionsList.CheckedItems[i].ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void optionsList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }
    }
}
