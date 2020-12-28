using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rifiuti.dataClasses;

namespace Rifiuti.dataClasses
{
    public class MUD
    {
        public int CER;
        public bool verified;
        public int initialValue;
        public int finalValue;
        public int cerTotal;
        public List<string> firms;
        public List<string> locations;
        public List<int> firmsTotal;
        public List<int> locationsTotal;
        public List<List<int>> data;
        public List<Tuple<string, string, string, int>> extraFirms;
        public int year;

        public MUD(int CER, bool verified, int initial, int final, int cerTotal ,List<string> firms, List<string> locations, List<int> firmsTotal, List<int> locationsTotal, List<List<int>> data, List<Tuple<string, string, string, int>> extraFirms, int year)
        {
            this.CER = CER;
            this.verified = verified;
            this.initialValue = initial;
            this.finalValue = final;
            this.cerTotal = cerTotal;
            this.firms = firms;
            this.locations = locations;
            this.firmsTotal = firmsTotal;
            this.locationsTotal = locationsTotal;
            this.data = data;
            this.extraFirms = extraFirms;
            this.year = year;
        }

        public string[] getFields()
        {
            List<string> ret = new List<string>();

            ret.Add("Comuni");

            foreach (var firm in this.firms)
                ret.Add(firm);

            ret.Add("Totale");

            return ret.ToArray();
        }

        public object[][] getObj()
        {
            List <object[] > obj = new List<object[]>();
            List<object> buffer;

            for(int i = 0; i < this.locations.Count; i++)
            {
                buffer = new List<object>();

                buffer.Add(this.locations[i]);

                foreach (var el in this.data[i])
                    buffer.Add(el);

                buffer.Add(this.locationsTotal[i]);

                obj.Add(buffer.ToArray());
            }


            buffer = new List<object>();

            buffer.Add("Totale");
            foreach (var tot in this.firmsTotal)
                buffer.Add(tot);
            buffer.Add(this.cerTotal);

            obj.Add(buffer.ToArray());

            return obj.ToArray();
        }

    }
}
