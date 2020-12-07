using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.dataClasses
{
    public class MonthElement
    {
        public string firm;
        public List<VeichleElement> veichles;

        public MonthElement(string firm, List<VeichleElement> veichles)
        {
            this.firm = firm;
            this.veichles = veichles;
        }

        public string getString(string separator)
        {
            string text = "";

            text += firm + separator;
            foreach (var veichle in this.veichles)
            {
                text += veichle.veichle.plateType + separator + veichle.veichle.plate + separator;
                foreach (var date in veichle.dates)
                {
                    text += date.date + separator + date.count + separator;
                }
            }

            return text;
        }
    }

    public class VeichleElement
    {
        public (string plateType, string plate) veichle;
        public List<(DateTime date, int count)> dates;
        public int normalCount;
        public int toBreakCount;
        public int asphaltCount;
        public int totalCount;

        public VeichleElement((string plate, string plateType) veichle, List<(DateTime date, int count)> dates, int normalCount, int toBreakCount, int asphaltCount, int totalCount)
        {
            this.veichle = veichle;
            this.dates = dates;
            this.normalCount = normalCount;
            this.toBreakCount = toBreakCount;
            this.asphaltCount = asphaltCount;
            this.totalCount = totalCount;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.veichle.plate + separator;
            text += this.veichle.plateType += separator;
            foreach (var element in this.dates)
                text += element.ToString() + separator;
            text += totalCount.ToString();

            return text;
        }
    }
}
