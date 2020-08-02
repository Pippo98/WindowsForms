using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    public class Analysis
    {

        public int id;
        public string date;
        public string CER;
        public string siteName;
        public string siteLocation;
        public string producer;
        public string code;

        public Analysis(int id_, string date_, string CER_, string siteName_, string siteLocation_, string producer_, string code_)
        {
            this.id             = id_;
            this.date           = date_;
            this.CER            = CER_;
            this.siteName       = siteName_;
            this.siteLocation   = siteLocation_;
            this.producer       = producer_;
            this.code           = code_;
        }
    }
}
