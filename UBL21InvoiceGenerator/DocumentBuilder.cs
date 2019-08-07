using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBL21InvoiceGenerator.Enums;

namespace UBL21InvoiceGenerator
{
    public class DocumentBuilder
    {
        public AbstractDocument BuildDocument(DocumentToBuildEnum? documentToBuild = null)
        {
            AbstractDocument document = null;

            switch (documentToBuild)
            {
                case DocumentToBuildEnum.FreeOfChargeDocument:
                    break;
                case DocumentToBuildEnum.TaxDocument:
                    break;
                case DocumentToBuildEnum.WithholdingTaxDocument:
                    break;
                default:
                    document = new GenericDocument();
                    break;
            }

            return document;
        }
    }
}
