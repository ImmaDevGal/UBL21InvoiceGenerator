﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    class Tax
    {
        Decimal taxAmount { get; set; }
        Decimal taxableAmpunt { get; set; }
        Int32 percentage { get; set; }
        String taxSchemeId { get; set; }
        String taxScgemeName { get; set; }

    }
}