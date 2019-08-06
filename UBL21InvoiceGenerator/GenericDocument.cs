using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBL21InvoiceGenerator.Model;

namespace UBL21InvoiceGenerator
{
    public class GenericDocument : AbstractDocument, IDocument
    {

        GenericDocument()
        {
            Lines = GetLines();
        }

        public void GenerateDocument()
        {

            Total = GetTotal();
        }

        //Get Tax
        void GetTaxes()
        {
            
            var lineWithTax = Lines.Line.Where(t => t.Tax.TaxAmount > 0);
            //if(lineWithTax != null)
            //{
            //    foreach(Line line in Lines.Line)
            //    {
            //        var documentTax = new Tax();
            //        //documentTax = Lines.Line.Tax;
            //        Taxes.Tax.Add(documentTax);
            //    }
            //}
            
            var something = Lines.Line.Where(line => line.Tax != null).Select(line => line.Tax);
        }

        //Get Lines
        Lines GetLines(){
            
            int numberOfLines = random.Next(1, 5);
            for (int i = 1; i <= numberOfLines; i++)
            {
                Lines.Line.Add(new Line(i));
            }
            return Lines;
        }

       //Set Total
       Total GetTotal()
        {   
            foreach (Line Line in Lines.Line)
            {
                Total.LineExtensionAmount += Line.Amount;
                Total.TaxExclusiveAmount += Line.Amount;
                Total.PayableAmount += Line.GetTotalAmount();

            }
            return Total;
        }
        
    }
}
