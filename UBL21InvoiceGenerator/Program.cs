using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;

namespace UBL21InvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentGenerator documentGenerator = new DocumentGenerator();

            List<DocumentData> documents = documentGenerator.GetDocumentData();

            var myTemplate = CreateMainFile();

            foreach (var document in documents)
            {
                var hi = Mustache.cs.Mustache.render(myTemplate, document);
                Console.WriteLine(hi.ToString());
            }
            Console.ReadLine();
        }

        private static string CreateMainFile()
        {
            var path = ConfigurationManager.AppSettings["XmlPath"];
            //var content = System.IO.File.ReadAllBytes(path);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            string xmlcontents = doc.InnerXml;
            return xmlcontents;
        }
    }
}
