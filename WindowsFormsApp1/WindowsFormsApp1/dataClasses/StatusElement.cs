using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    class StatusElement
    {
        public DateTime date;
        public int total;
        public List<CERElement> CERElements;
        public bool hasLoaded;
        public bool hasUnloaded;
        public ExtraProcessingElement extra;

        public StatusElement(DateTime date, int total, List<CERElement> CERElements, bool hasLoaded, bool hasUnloaded, ExtraProcessingElement extra = null)
        {
            this.date = date;
            this.total = total;
            this.CERElements = CERElements;
            this.hasLoaded = hasLoaded;
            this.hasUnloaded = hasUnloaded;
            if (extra != null)
                this.extra = extra;
        }

        public string[] getFields(int[] cers)
        {
            List<string> ret = new List<string>();

            ret.Add("Data");
            ret.Add("Totale");
            foreach (var element in CERElements)
                foreach (var el in element.getFields())
                    ret.Add(element.CER.ToString() + "\n" + el);

            return ret.ToArray();
        }

        public object[] getObj()
        {
            List<object> obj = new List<object>();

            obj.Add(date.ToString("d"));
            obj.Add(total);

            foreach (var element in CERElements)
                foreach (var el in element.getObj())
                    obj.Add(el);

            return obj.ToArray();
        }

        public int getTotal()
        {
            int total = 0;
            foreach (var element in this.CERElements)
            {
                total += element.CERTotal;
            }
            return total;
        }

        public string getString(string separator)
        {
            string ret = "";

            ret += date.ToString("d") + separator;
            ret += total.ToString() + separator;

            foreach (var el in this.CERElements)
                ret += "{" + el.getString(" ") + "}" + separator;

            return ret;
        }
    }

    class CERElement
    {
        public int CER;
        public int load;
        public int unload;
        public int CERTotal;

        public CERElement(int CER, int load, int unload, int CERTotal)
        {
            this.CER = CER;
            this.load = load;
            this.unload = unload;
            this.CERTotal = CERTotal;
        }

        public string[] getFields()
        {
            string[] ret = new string[]
            {
                "Load",
                "Unload",
                "Total"
            };
            return ret;
        }

        public object[] getObj()
        {
            List<object> obj = new List<object>();
            obj.Add(this.load);
            obj.Add(this.unload);
            obj.Add(this.CERTotal);

            return obj.ToArray();
        }

        public string getString(string separator)
        {
            string ret = "";

            ret += CER + separator;
            ret += load + separator;
            ret += unload + separator;
            ret += CERTotal + separator;

            return ret;
        }
    }

    class ExtraProcessingElement
    {
        public int processed;
        public string processedType;
        public int q1;
        public int q2;
        public int q3;

        public ExtraProcessingElement(string processedType, int processed, int q1, int q2, int q3)
        {
            this.processedType = processedType;
            this.processed = processed;
            this.q1 = q1;
            this.q2 = q2;
            this.q3 = q3;
        }
    }
}
