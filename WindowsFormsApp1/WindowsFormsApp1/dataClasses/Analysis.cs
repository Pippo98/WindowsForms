using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    public class Analysis
    {

        public int id;
        public DateTime date;
        public string CER;
        public string siteName;
        public string siteLocation;
        public string producer;
        public string validity;
        public string code;

        public Analysis(int id_, DateTime date_, string CER_, string siteName_, string siteLocation_, string producer_, string validity_)
        {
            this.id             = id_;
            this.date           = date_;
            this.CER            = CER_;
            this.siteName       = siteName_;
            this.siteLocation   = siteLocation_;
            this.producer       = producer_;
            this.validity       = validity_;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.id.ToString() + separator;
            text += this.date.ToString() + separator;
            text += this.CER + separator;
            text += this.siteName + separator;
            text += this.siteLocation + separator;
            text += this.producer + separator;
            text += this.validity;

            return text;
        }
    }
}
