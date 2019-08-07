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
            DocumentBuilder documentBuilder = new DocumentBuilder();
            AbstractDocument document = documentBuilder.BuildDocument();
            document.GenerateDocument();

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
