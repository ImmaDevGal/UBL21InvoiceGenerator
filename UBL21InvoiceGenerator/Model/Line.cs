using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class Line
    {
        Int32 Id { get; set; }

        public String Description {
            get
            {
                return productNames[random.Next(0, productNames.Length)];
            }
        }

        public Decimal Quantity { private set; get; }

        public Decimal Price {private set; get;}

        public Decimal Amount {
            get
            {
               return (Price * Quantity);
            }
        }

        public Tax Tax;
        public WithholdingTax WithholdingTax;
        private string[] productNames;
        private Random random;

        public Line(Int32 id)
        {
            this.Id = id;
            random = new Random(Environment.TickCount);
            productNames = File.ReadAllLines(@"AppData\Productos.txt");
            Price = GetPrice();
            Quantity = GetQuantity();
        }

        public Decimal GetPrice()
        {
            return random.Next(10000, 900000);
        }

        public Decimal GetQuantity()
        {
            return random.Next(1, 100);
        }

        public Decimal GetTotalSubTotalAmount()
        {
            return (Price * Quantity);
        }

        public Decimal GetTotalAmount()
        {
            Tax = new Tax();
            WithholdingTax = new WithholdingTax();
            return (Price * Quantity) + Tax.TaxAmount;
        }
        
    }

}
