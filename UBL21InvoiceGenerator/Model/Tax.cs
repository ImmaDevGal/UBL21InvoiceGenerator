using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class Tax
    {
        public Decimal TaxAmount { get; set; }
        public Decimal TaxableAmount { get; set; }
        public Int32 Percentage { get; set; }
        public String TaxSchemeId { get; set; }
        public String TaxSchemeName { get; set; }

        public Tax() { }
        public Tax(Decimal taxableAmount)
        {
            this.TaxableAmount = taxableAmount;
        }

    }

    public class Taxes
    {
        public List<Tax> Tax { get; set; }
    }
}
