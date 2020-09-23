using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    public class Site
    {
        public string location;
        public List<string> names;

        public Site(string location_, List<string> names_)
        {
            this.location   = location_;
            this.names      = names_;
        }

        public string[] getFields()
        {
            string[] ret =
            {
                "Comune",
                "Cantieri"
            };
            return ret;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.location;

            foreach(var el in this.names)
                text += separator + el;

            return text;
        }
    }
}
