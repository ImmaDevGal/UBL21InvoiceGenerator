using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator
{
    public class DocumentGenerator
    {
        private string[] _productNames;
        private Random random;
        List<ItemData> itemsDataList;
        List<DocumentData> documentDataList;

        public DocumentGenerator()
        {
            random = new Random(Environment.TickCount);
            _productNames = File.ReadAllLines(@"AppData\Productos.txt");
            documentDataList = new List<DocumentData>();
        }

        public List<DocumentData> GetDocumentData()
        {
            Int32 _tax = 0;
            Int32 documentQuantity = Convert.ToInt32(ConfigurationManager.AppSettings["DocumentQuantity"]);

            for (int i = 1; i <= documentQuantity; i++)
            {
                int _itemNumber = 1;
                Decimal _totalNet = 0;
                Decimal _totalTax = 0;
                Decimal _totalAmount = 0;
                itemsDataList = GetItemsData();

                //Sumatoria para totales
                foreach (ItemData id in itemsDataList)
                {
                    _itemNumber += _itemNumber;
                    _tax = id.tax;
                    _totalNet += id.totalNetAmount;
                    _totalTax += id.taxPercentageAmount;
                    _totalAmount += id.totalAmount;
                }

                //Objeto para el nodo de totales
                DocumentData totalesFac = new DocumentData()
                {                   
                    tax = _tax,
                    totalNetAmount = _totalNet,
                    taxPercentageAmount = _totalTax,
                    totalAmount = _totalAmount,
                    itemsData = itemsDataList
                };

                documentDataList.Add(totalesFac);
            }

            return documentDataList;
        }

        protected List<ItemData> GetItemsData()
        {
            int lineQuantity = random.Next(1, 5);
            Int32 _tax = GetTaxPercentage();
            List<ItemData> _documentData = new List<ItemData>();

            for (int i = 1; i <= lineQuantity; i++)
            {
                Int32 _quantity = GetItemQuantity();
                Decimal _priceAmount = GetPriceAmount();

                _documentData.Add(new ItemData()
                {
                    itemDescription = GetItemDescription(),
                    priceAmount = _priceAmount,
                    itemQuantity = _quantity,
                    tax = _tax,
                    totalNetAmount = (_priceAmount * _quantity),
                    taxPercentageAmount = ((_priceAmount * _quantity) * (_tax)) / 100,
                    totalAmount = (_priceAmount * _quantity) + (((_priceAmount * _quantity) * (_tax)) / 100)
                });
            }
            return _documentData;
        }


        #region RandomData
        protected String GetItemDescription()
        {
            String nombreProducto = _productNames[random.Next(0, _productNames.Length)];
            return nombreProducto;
        }

        protected Decimal GetPriceAmount()
        {
            Decimal priceAmount = random.Next(1000, 500000);
            return priceAmount;
        }

        protected Int32 GetItemQuantity()
        {
            Int32 quantity = random.Next(1, 500);
            return quantity;
        }

        protected Int32 GetTaxPercentage()
        {
            Int32[] taxArray = { 8, 16 };
            Int32 tax = taxArray[random.Next(0, taxArray.Length)];
            return tax;
        }

        #endregion
    }
}
