using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    public class Month
    {
        public List<Firm> firms;
        public List<DateTime> dates;

        public Month(List<Firm> firms, List<DateTime> dates)
        {
            this.firms = firms;
            this.dates = dates;
        }
    }
}
