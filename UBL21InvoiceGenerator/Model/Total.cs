using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class Total
    {
        public Decimal LineExtensionAmount { get; set; }
        public Decimal TaxExclusiveAmount { get; set; }
        public Decimal TaxInclusiveAmount { get; set; }
        public Decimal AllowaceTotalAmount { get; set; }
        public Decimal ChargeTotalAmount { get; set; }
        public Decimal PayableAmount { get; set; }
    }
}
