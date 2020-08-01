using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    class Site
    {
        public string location;
        public string name;

        public Site(string location_, string name_)
        {
            this.location   = location_;
            this.name       = name_;
        }
    }
}
