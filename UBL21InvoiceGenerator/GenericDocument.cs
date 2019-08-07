using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBL21InvoiceGenerator.Model;

namespace UBL21InvoiceGenerator
{
    public class GenericDocument : AbstractDocument
    {
        public void GenerateDocument()
        {
            Lines = new List<Line>();
            Total = new Total();
            Lines = GetLines();
            Total = GetTotal();

            Console.WriteLine("Primera linea :" + Lines.FirstOrDefault());
            Console.WriteLine("Total :" + Total.PayableAmount);
        }

        //Get Tax
        void GetTaxes()
        {
            
            var lineWithTax = Lines.Where(t => t.Tax.TaxAmount > 0);
            //if(lineWithTax != null)
            //{
            //    foreach(Line line in Lines.Line)
            //    {
            //        var documentTax = new Tax();
            //        //documentTax = Lines.Line.Tax;
            //        Taxes.Tax.Add(documentTax);
            //    }
            //}
            
            var something = Lines.Where(line => line.Tax != null).Select(line => line.Tax);
        }

        //Get Lines
        List<Line> GetLines(){
            
            int numberOfLines = random.Next(1, 5);
            for (int i = 1; i <= numberOfLines; i++)
            {
                Lines.Add(new Line(i));
            }
            return Lines;
        }

       //Set Total
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
