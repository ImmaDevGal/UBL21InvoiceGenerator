using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    class Line
    {
          Int32 id { get; set; }
        String description { get; set; }
        Decimal quantity { get; set; }
        Decimal price { get; set; }
        Decimal amount { get; set; }
        Tax tax;
        WithholdingTax withholdingTax;      

    }
}
