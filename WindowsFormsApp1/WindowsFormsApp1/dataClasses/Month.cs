﻿using System;
using System.Collections.Generic;

namespace Rifiuti.dataClasses
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
