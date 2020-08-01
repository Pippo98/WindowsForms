using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{

    class Firm
    {
        public string name;
        public Tuple<string, string>[] targhe;

        public Firm(string name_, Tuple<string, string>[] targhe_)
        {
            this.name       = name_;
            this.targhe     = targhe_;
        }
    }
}
