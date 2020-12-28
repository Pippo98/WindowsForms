using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rifiuti.Print
{
    public partial class Help : Form
    {
        public Help(string projectPath, string pdfPath)
        {
            InitializeComponent();
            this.richTextBox1.Text = "" +
                "Program to store data of a waste implant.\n\n" +
                "Imprese are all the firms that can load/unload to/from the implant.\n" +
                "Cantieri are all the locations where the waste is produced or where the waste is transported.\n" +
                "Analisi are all the documents that certifies that in that specific location is produces that type of waste.\n" +
                "Registro Impianto/Varie is a list of all the ducuments collected from firms that have loaded/unloaded.\n" +
                "CER is a number that identifies a type of waste.\n" +
                "\n" +
                "Situazione is a table where is shown the status of the implant, so all the quantities stored for each type of waste (CER).\n" +
                "Mesi is a collection of tables (one for each month) that shows how many loads/unloads were done every day for each firm.\n" +
                "MUD is a document for each CER that shows all the quantities transported from each firm in each location during an entire year.\n" +
                "\n\n" +
                "PRINTING\n" +
                "Stampa button shows a dialog where can be selected the type of PDF document that need to be printed.\n" +
                "The output files are located in the default folder.\n" +
                pdfPath +
                "\n\n" +
                "ERRORS\n" +
                "If the program suddenly closes or shows some error messages is maybe for the last changes that were done from the user.\n" +
                "If restarting the program doesn't fix any problem try opening the project path folder and check in the single files if there are some discontinuity in the text formattig.\n" +
                "The program uses ';' to separate fields in all files and using that character in a field (ex. a location name contains ';') can cause problems when reading the files.\n" +
                "\n"+
                "Current Project folder: \n" +
                projectPath
                ;
        }
    }
}
