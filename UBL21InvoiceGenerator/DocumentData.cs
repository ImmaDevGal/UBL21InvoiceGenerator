using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    public class DocumentData
    {
        public Int32 tax { get; set; }
        public Decimal totalNetAmount { get; set; }
        public Decimal taxPercentageAmount { get; set; }
        public Decimal totalAmount { get; set; }
        public List<ItemData> itemsData { get; set; }

    }
}


