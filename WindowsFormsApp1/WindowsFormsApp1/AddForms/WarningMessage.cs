using System.Windows.Forms;

namespace Rifiuti.AddForms
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
