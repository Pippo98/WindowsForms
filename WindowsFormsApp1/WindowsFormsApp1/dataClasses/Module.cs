using System;

namespace Rifiuti.dataClasses
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
        public int CER;
        public string toBreak;
        public int kg;
        public string siteLocation;
        public string siteName;
        public string note;

        public Module(int id, DateTime date, string loadUnload, string producer, string carrier, string plate, string dimension, int CER, string siteLocation, string siteName, string toBreak, int kg, string note, string destination = "none")
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

        public object[] getObj(string type)
        {
            object[] obj;
            if (type == "Implant")
            {
                obj = new object[]
                {
                    id,
                    date.ToString("d"),
                    loadUnload,
                    producer,
                    carrier,
                    dimension + "-" + plate,
                    CER,
                    toBreak,
                    kg,
                    siteLocation,
                    siteName,
                    note,
                };
            }
            else
            {
                obj = new object[]
                {
                    id,
                    date.ToString("d"),
                    loadUnload,
                    producer,
                    carrier,
                    destination,
                    dimension + "-" + plate,
                    CER,
                    toBreak,
                    kg,
                    siteLocation,
                    siteName,
                    note,
                };
            }
            return obj;
        }

        public string[] getFields(string type)
        {
            string[] ret;
            if (type == "Implant")
            {
                ret = new string[]
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
                    "Cantiere",
                    "Note"
                };
            }
            else
            {
                ret = new string[]
                {
                    "ID",
                    "Data",
                    "Carico/Scarico",
                    "Produttore",
                    "Trasportatore",
                    "Destinazione",
                    "Mezzo",
                    "CER",
                    "Pizare",
                    "Kg",
                    "Comune",
                    "Cantiere",
                    "Note"
                };
            }

            return ret;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.id.ToString() + separator;
            text += this.date.ToString("d") + separator;
            text += this.loadUnload + separator;
            text += this.producer + separator;
            text += this.carrier + separator;
            if (destination != "none")
                text += this.destination + separator;
            text += this.dimension + "-" + this.plate + separator;
            text += this.CER.ToString() + separator;
            text += this.kg.ToString() + separator;
            text += this.siteLocation + separator;
            text += this.siteName + separator;
            text += this.toBreak + separator;
            text += this.note;

            return text;
        }

    }
}
