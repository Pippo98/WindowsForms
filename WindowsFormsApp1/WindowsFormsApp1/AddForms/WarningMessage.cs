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
    public partial class WarningMessage : Form
    {
        public WarningMessage(string warningText)
        {
            InitializeComponent();
            this.warnTextBox.Text = warningText;
        }
    }
}
