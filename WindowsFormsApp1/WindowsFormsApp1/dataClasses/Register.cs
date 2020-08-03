using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    public class Register
    {
        // NOTE,DATA,C/S,IMPRESA,TRASPORTATORE,DESTINAZIONE,MEZZO,CER,KG,COMUNE,CANTIERE
        public string id;
        public string date;
        public string loadUnload;
        public string producer;
        public string carrier;
        public string destination;
        public string plate;
        public string CER;
        public string kg;
        public string siteLocation;
        public string siteName;

        public Register(string id, string date, string loadUnload, string producer, string carrier, string destination, string plate, string CER, string kg, string siteLocation, string siteName)
        {
            this.id = id;
            this.date = date;
            this.loadUnload = loadUnload;
            this.producer = producer;
            this.carrier = carrier;
            this.destination = destination;
            this.plate = plate;
            this.CER = CER;
            this.kg = kg;
            this.siteLocation = siteLocation;
            this.siteName = siteName;
        }
    }
}
