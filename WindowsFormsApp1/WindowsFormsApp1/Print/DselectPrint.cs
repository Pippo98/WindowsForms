using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1.Print
{
    public partial class DselectPrint : Form
    {

        private List<string> options;

        public string[] selected;

        public DselectPrint(string[] options_)
        {
            InitializeComponent();


            this.options = new List<string>();
            this.options.Add("Seleziona Tutti");
            for (int i = 0; i < options_.Length; i++)
            {
                this.options.Add(options_[i]);
            }

            this.optionsList.Items.AddRange(this.options.ToArray());

            this.selected = new string[options.Count];
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
            if (e.Index == 0)
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    for (int idx = 1; idx < this.optionsList.Items.Count; idx++)
                        this.optionsList.SetItemChecked(idx, true);

                }
                else
                {
                    for (int idx = 1; idx < this.optionsList.Items.Count; idx++)
                        this.optionsList.SetItemChecked(idx, false);
                }
            }

        }
    }
}
