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
    public class Module
    {
        // NOTE,DATA,C/S,IMPRESA,TRASPORTATORE,DESTINAZIONE,MEZZO,CER,KG,COMUNE,CANTIERE
        public int id;
        public DateTime date;
        public string loadUnload;
        public string producer;
        public string carrier;
        public string destination;
        public string plate;
        public string dimension;
        public string CER;
        public bool toBreak;
        public int kg;
        public string siteLocation;
        public string siteName;
        public string note;

        public Module(int id, DateTime date, string loadUnload, string producer, string carrier, string plate, string dimension, string CER, string siteLocation, string siteName, bool toBreak, int kg, string note, string destination = "")
        {
            this.id = id;
            this.date = date;
            this.loadUnload = loadUnload;
            this.producer = producer;
            this.carrier = carrier;
            this.destination = destination;
            this.plate = plate;
            this.dimension = dimension;
            this.CER = CER;
            this.toBreak = toBreak;
            this.kg = kg;
            this.siteLocation = siteLocation;
            this.siteName = siteName;
            this.note = note;
        }

        public object[] getOjb()
        {
            object[] obj =
            {
                id,
                date,
                loadUnload,
                producer,
                carrier,
                //destination,
                dimension + "-" + plate,
                CER,
                toBreak,
                kg,
                siteLocation,
                siteName,
                note,
            };
            return obj;
        }

        public string[] getFields()
        {
            string[] ret =
            {
                "ID",
                "Data",
                "Carico/Scarico",
                "Produttore",
                "Trasportatore",
                "Mezzo",
                "CER",
                "Pizare",
                "Kg",
                "Comune",
                "Cantiere"
            };

            return ret;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.id.ToString() + separator;
            text += this.date.ToString() + separator;
            text += this.loadUnload + separator;
            text += this.producer + separator;
            text += this.carrier + separator;
            if(destination != "")
                text += this.destination + separator;
            text += this.dimension + "-" + this.plate + separator;
            text += this.CER + separator;
            text += this.toBreak + separator;
            text += this.kg.ToString() + separator;
            text += this.siteLocation + separator;
            text += this.siteName;

            return text;
        }

    }
}
