using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBL21InvoiceGenerator.Model;

namespace UBL21InvoiceGenerator
{
    public abstract class AbstractDocument
    {
        public String DocumentType { get; set; }
        public List<Tax> Taxes { get; set; }
        public List<WithholdingTax> WithholdingTaxes { get; set; }
        public List<Line> Lines { get; set; }
        public Total Total { get; set; }
        public Random random { get; set; }

        public AbstractDocument()
        {
            random = new Random(Environment.TickCount);
            
        }

    }
}
