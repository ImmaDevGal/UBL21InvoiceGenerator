using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    class Document
    {
        String documentType { get; set; }
        List<Tax> taxes;
        List<WithholdingTax> withholdingTaxes;
        List<Line> lines;
        Total total;
    }
}
