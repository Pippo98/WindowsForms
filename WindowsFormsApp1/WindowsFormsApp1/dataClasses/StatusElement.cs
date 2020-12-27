using System;
using System.Collections.Generic;

namespace Rifiuti.dataClasses
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

        public string[] getFields(List<int> cers)
        {
            List<string> ret = new List<string>();

            ret.Add("Data");
            ret.Add("Totale");
            int cnt1 = 0;
            foreach (var element in CERElements)
            {
                int cnt2 = 0;
                foreach (var el in element.getFields())
                {
                    if(cnt2 == 1)
                    {
                        ret.Add(element.CER.ToString() + "\n" + el);
                    }
                    else
                    {
                        string space = "";
                        for (int _ = 0; _ < cnt1; _++)
                            space += " ";
                        ret.Add(el + space);
                    }
                    cnt2 ++;
                }
                cnt1 ++;
            }


            return ret.ToArray();
        }

        public object[] getObj()
        {
            List<object> obj = new List<object>();
            string stringSpecifier = "#,#0";

            obj.Add(date.ToString("d"));
            obj.Add(total.ToString(stringSpecifier));

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
            string stringSpecifier = "#,#0";

            List<object> obj = new List<object>();
            obj.Add(this.load.ToString(stringSpecifier));
            obj.Add(this.unload.ToString(stringSpecifier));
            obj.Add(this.CERTotal.ToString(stringSpecifier));

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
