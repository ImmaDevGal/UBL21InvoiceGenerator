using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UBL21InvoiceGenerator.UBL21InvoiceGenerator;

namespace UBL21InvoiceGenerator
{
    public class DocumentParser
    {

        public DocumentParser()
        {
            DocumentBuilder documentBuilder = new DocumentBuilder();
            AbstractDocument document = documentBuilder.BuildDocument();
            document.GenerateDocument();
            
            var template = CreateMainFile();
            var hi = Mustache.cs.Mustache.render(template, document);
            Console.WriteLine(hi.ToString());

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
