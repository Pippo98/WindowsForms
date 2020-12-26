using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Rifiuti.dataClasses;

namespace Rifiuti.EditForms
{
    public partial class DEditStatus : Form
    {
        public List<dataClasses.InitialStatus> InitialStatuses;
        public DEditStatus(List<dataClasses.InitialStatus> initialStatuses)
        {
            InitializeComponent();

            this.InitialStatuses = initialStatuses;

            this.updateValues();
        }

        private void updateValues()
        {
            this.CERCombo.Items.Clear();
            this.StatusValueText.Text = "";
            this.statusList.Items.Clear();
            this.CERCombo.SelectedItem = null;

            var CERs = this.InitialStatuses.Select(x => x.CER).ToArray();
            var values = this.InitialStatuses.Select(x => x.quantity);

            List<string> strItems = new List<string>();
            foreach (var e in CERs)
                strItems.Add(e.ToString());
            this.CERCombo.Items.AddRange(strItems.ToArray());

            strItems = new List<string>();
            foreach (var e in values)
                strItems.Add(e.ToString());

            strItems = new List<string>();
            foreach (var e in this.InitialStatuses)
                strItems.Add(e.CER.ToString() + "\t" + e.quantity.ToString() + "\n");
            this.statusList.Items.AddRange(strItems.ToArray());
        }

        private void CERCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CERCombo.SelectedIndex == -1)
                return;
            var cer = int.Parse(this.CERCombo.SelectedItem.ToString());
            var el = this.InitialStatuses.Find(x => x.CER == cer);
            this.StatusValueText.Text = el.quantity.ToString();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Name == "updateButton")
            {
                if (this.CERCombo.SelectedIndex == -1 || this.StatusValueText.Text == "")
                    return;
                var cer = int.Parse(this.CERCombo.SelectedItem.ToString());
                var el = this.InitialStatuses.Find(x => x.CER == cer);

                if (el == null)
                    return;

                el.quantity = int.Parse(this.StatusValueText.Text);

                this.updateValues();
            }
            else if(btn.Name == "OK")
            {
                if (this.CERCombo.SelectedIndex != -1 && this.StatusValueText.Text != "")
                {
                    var cer = int.Parse(this.CERCombo.SelectedItem.ToString());
                    var el = this.InitialStatuses.Find(x => x.CER == cer);

                    if (el == null)
                        return;

                    el.quantity = int.Parse(this.StatusValueText.Text);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (btn.Name == "cancel")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
