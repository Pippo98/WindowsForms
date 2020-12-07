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
