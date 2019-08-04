using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    class Charge
    {
        Int32 id { get; set; }
        Boolean indicator { get; }
        String reason { get; set; }
        Decimal factor { get; set; }
        Decimal amount { get; set; }
        Decimal baseAmount { get; set; }

    }
}
