using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rifiuti.dataClasses
{
    class ExtraProcessing
    {
        public DateTime date;
        public string type;




    }
    class InitialStatus
    {
        public (int CER, int quantity) status;

        public InitialStatus(int CER, int quantity)
        {
            this.status = (CER, quantity);
        }
    }
}
