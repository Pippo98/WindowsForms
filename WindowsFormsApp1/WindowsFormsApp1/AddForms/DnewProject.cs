using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.AddForms
{
    public partial class DnewProject : Form
    {

        public string name;
        public DnewProject()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            // Warning message
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {

            if (this.nameText.Text != "")
            {
                this.name = this.nameText.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errorProvider.SetError(nameText, "Aggiungi un nome");
            }
        }
    }
}
