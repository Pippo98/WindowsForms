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

        public string id;
        public string date;
        public string CER;
        public string siteName;
        public string siteLocation;
        public string producer;
        public string validity;
        public string code;

        public Analysis(string id_, string date_, string CER_, string siteName_, string siteLocation_, string producer_, string validity_)
        {
            this.id             = id_;
            this.date           = date_;
            this.CER            = CER_;
            this.siteName       = siteName_;
            this.siteLocation   = siteLocation_;
            this.producer       = producer_;
            this.validity       = validity_;
        }
    }
}
