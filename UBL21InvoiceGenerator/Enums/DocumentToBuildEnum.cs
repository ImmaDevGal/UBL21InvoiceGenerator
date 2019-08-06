using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Enums
{
   public enum DocumentToBuildEnum
    {
        GenericDocument,
        TaxDocument,
        WithholdingTaxDocument, 
        FreeOfChargeDocument
    }
}
