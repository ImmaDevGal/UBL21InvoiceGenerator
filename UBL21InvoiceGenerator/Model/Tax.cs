using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class Tax : BaseUtilities
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
            SetUpTax();
        }

        public void SetUpTax()
        {
            TaxSetUp taxSetUp = GetOneTax();
            TaxSchemeId = taxSetUp.Id;
            TaxSchemeName = taxSetUp.Name;
            Percentage = taxSetUp.Porcentage;
            TaxAmount = GetTaxAmount();
        }

        public Decimal GetTaxAmount()
        {
            return (TaxableAmount * Percentage) / 100;
        }

        public TaxSetUp GetOneTax()
        {
            var taxes = new Dictionary<int, TaxSetUp>()
            {
                { 1, new TaxSetUp { Id = "01", Name="IVA", Description="Iva19", Porcentage=19} },
                { 2, new TaxSetUp { Id = "02", Name="IC", Description="Ic8", Porcentage=8} },
                { 3, new TaxSetUp { Id = "03", Name="ICA", Description="Ica", Porcentage=4} },
                { 4, new TaxSetUp { Id = "04", Name="INC", Description="Inc8", Porcentage=8} }
            };

            var tax = taxes[random.Next(0, taxes.Count())];
            return tax;
        }        
    }

    public class TaxSetUp
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Int32 Porcentage { get; set; }

    }

}
