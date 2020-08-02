using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    public class Site
    {
        public string location;
        public string[] names;

        public Site(string location_, string[] names_)
        {
            this.location   = location_;
            this.names      = names_;
        }
    }
}
