using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBL21InvoiceGenerator.Model;
using UBL21InvoiceGenerator.UBL21InvoiceGenerator;

namespace UBL21InvoiceGenerator
{
    public class GenericDocument : AbstractDocument
    {
        public override void GenerateDocument()
        {
            Lines = new List<Line>();
            Total = new Total();
            Lines = GetLines();
            Total = GetTotal();
            Taxes = GetTaxes();

            Console.WriteLine("Id Primera linea :" + Lines.FirstOrDefault().Id);
            Console.WriteLine("Total :" + Total.PayableAmount);
        }

        //Get Tax
        public List<Tax> GetTaxes()
        {
            List<Tax> taxes = new List<Tax>();
            var lineWithTax = Lines.Where(t => t.Tax.TaxAmount > 0);
            taxes = Lines?.Where(line => line.Tax != null)?.Select(line => line.Tax)?.ToList();
            return taxes;
        }

        List<Line> GetLines()
        {

            int numberOfLines = random.Next(1, 5);
            for (int i = 1; i <= numberOfLines; i++)
            {
                Lines.Add(new Line(i));
            }
            return Lines;
        }
        Total GetTotal()
        {
            foreach (Line Line in Lines)
            {
                Total.LineExtensionAmount += Line.Amount;
                Total.TaxExclusiveAmount += Line.Amount;
                Total.PayableAmount += Line.GetTotalAmount();

            }
            return Total;
        }

    }
}