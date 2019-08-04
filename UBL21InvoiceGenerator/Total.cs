using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    class Total
    {
        Decimal lineExtensionAmount { get; set; }
        Decimal taxExclusiveAmpunt { get; set; }
        Decimal taxInclusiveAmount { get; set; }
        Decimal allowaceTotalAmount { get; set; }
        Decimal chargeTotalAmount { get; set; }
        Decimal payableAmount { get; set; }
    }
}
