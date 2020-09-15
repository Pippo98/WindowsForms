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
        public string getString(string separator)
        {
            string text = "";

            text += this.name;

            for (int i = 0; i < this.targhe.Count; i++)
                text += separator + this.targhe[i].Item1 + " - " + this.targhe[i].Item2;

            return text;
        }

        public string[] getFields()
        {
            string[] ret = { "Nome", "Mezzo" };
            return ret;
        }
    }
}
