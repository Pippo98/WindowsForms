using System;
using System.Collections.Generic;

namespace Rifiuti.dataClasses
{
    [Serializable]
    public class Firm : ICloneable
    {
        public string name { set; get; }
        public List<Tuple<string, string>> targhe { set; get; }

        public Firm(string name_, List<Tuple<string, string>> targhe_)
        {
            this.name = name_;
            this.targhe = targhe_;
        }
        public string getString(string separator)
        {
            string text = "";

            text += this.name;

            foreach (var el in this.targhe)
            {
                if (el.Item1 == null || el.Item2 == null)
                    continue;
                if (el.Item1 == "" && el.Item2 == "")
                    continue;
                text += separator + el.Item1 + "-" + el.Item2;
            }

            return text;
        }

        public string[] getFields()
        {
            string[] ret = { "Nome", "Mezzo" };
            return ret;
        }

        public object Clone()
        {
            return new Firm(this.name, this.targhe)
            {
                name = this.name,
                targhe = this.targhe,
            };
        }
    }
}
