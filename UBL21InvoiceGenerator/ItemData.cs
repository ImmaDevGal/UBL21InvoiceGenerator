using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    public class ItemData
    {
        public int itemNumber { get; set; }
        public String itemDescription { get; set; }
        public Decimal priceAmount { get; set; }
        public Int32 itemQuantity { get; set; }
        public Int32 tax { get; set; }
        public Decimal totalNetAmount { get; set; }
        public Decimal taxPercentageAmount { get; set; }
        public Decimal totalAmount { get; set; }

    }
}
