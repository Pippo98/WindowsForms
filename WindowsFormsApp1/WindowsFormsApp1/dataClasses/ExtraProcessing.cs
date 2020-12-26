using System;

namespace Rifiuti.dataClasses
{
    public class ExtraProcessing
    {
        public DateTime date;
        public string type;                 // Frantumato o vagliato

        public ExtraProcessing(DateTime date, string type)
        {
            this.date = date;
            this.type = type;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.date.ToString("d");
            text += separator + this.type.ToString();

            return text;
        }

    }
    public class InitialStatus
    {
        public int CER;
        public int quantity;

        public InitialStatus(int CER, int quantity)
        {
            this.CER = CER;
            this.quantity = quantity;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.CER.ToString();
            text += separator + this.quantity.ToString();

            return text;
        }
    }
}
