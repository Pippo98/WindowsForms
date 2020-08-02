using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{

    public class Firm
    {
        public string name;
        public List<Tuple<string, string>> targhe;

        public Firm(string name_, List<Tuple<string, string>> targhe_)
        {
            this.name       = name_;
            this.targhe     = targhe_;
        }
    }
}
