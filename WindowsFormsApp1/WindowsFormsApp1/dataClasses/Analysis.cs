using System;

namespace WindowsFormsApp1.dataClasses
{
    public class Analysis
    {

        public int id;
        public DateTime date;
        public int CER;
        public string siteName;
        public string siteLocation;
        public string producer;
        public string validity;
        public string code;

        public Analysis(int id, DateTime date, int CER, string siteName, string siteLocation, string producer, string validity)
        {
            this.id = id;
            this.date = date;
            this.CER = CER;
            this.siteName = siteName;
            this.siteLocation = siteLocation;
            this.producer = producer;
            this.validity = validity;
        }

        public string[] getFields()
        {
            var ret = new string[]
            {
                "ID",
                "Data",
                "CER",
                "Comune",
                "Cantiere",
                "Produttore",
                "Validità"
            };
            return ret;
        }

        public object[] getObj()
        {
            var ret = new object[]
            {
                this.id,
                this.date,
                this.CER,
                this.siteLocation,
                this.siteName,
                this.producer,
                this.validity
            };
            return ret;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.id.ToString() + separator;
            text += this.date.ToString() + separator;
            text += this.CER.ToString() + separator;
            text += this.siteName + separator;
            text += this.siteLocation + separator;
            text += this.producer + separator;
            text += this.validity;

            return text;
        }
    }
}
