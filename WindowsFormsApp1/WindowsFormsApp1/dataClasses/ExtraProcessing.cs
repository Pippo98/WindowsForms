using System;

namespace Rifiuti.dataClasses
{
    public class ExtraProcessing
    {
        public DateTime date;
        public int CER;
        public int quantity;
        public string type;                 // Frantumato o vagliato

        public ExtraProcessing(DateTime date, int CER, int quantity, string type)
        {
            this.date = date;
            this.CER = CER;
            this.quantity = quantity;
            this.type = type;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.date.ToString("d") + separator;
            text += this.CER.ToString() + separator;
            text += this.quantity.ToString() + separator;
            text += this.type.ToString();

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
