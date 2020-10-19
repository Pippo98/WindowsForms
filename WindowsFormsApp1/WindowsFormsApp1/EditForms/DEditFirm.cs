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
    public partial class DEditFirm : Form
    {
        public DEditFirm()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn.Name == "OKButton")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if(btn.Name == "DeleteButton")
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            if(btn.Name == "CancelButton")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
