using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class Line : BaseUtilities
    {
        public Int32 Id { get; set; }

        public String Description { get; set; }

        public Decimal Quantity { get; set; }

        public Decimal Price { get; set; }

        public Decimal Amount { get; set; }

        public Tax Tax { get; set; }
        public WithholdingTax WithholdingTax;
        private string[] productNames;
        

        public Line() { }
        public Line(Int32 id)
        {
            this.Id = id;
            productNames = File.ReadAllLines(@"AppData\Productos.txt");
            SetUpLine();
        }

        public void SetUpLine()
        {
            Description = GetDescription();
            Price = GetPrice();
            Quantity = GetQuantity();
            Amount = GetAmount();
            Tax = GetTax(); 
        }

        public string GetDescription()
        {
            return productNames[random.Next(0, productNames.Length)];
        }

        public Decimal GetPrice()
        {
            return random.Next(10000, 900000);
        }

        public Decimal GetQuantity()
        {
            return random.Next(1, 100);
        }

        public Decimal GetAmount()
        {
            return (Price * Quantity);
        }

        public Tax GetTax()
        {
            return new Tax(Amount);
        }

        public Decimal GetTotalAmount()
        {
            Tax = new Tax();
            WithholdingTax = new WithholdingTax();
            return (Price * Quantity) + Tax.TaxAmount;
        }

    }

}
