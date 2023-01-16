using System;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using TestImportXml;

namespace ProjetVersion_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Users\gaeta\Desktop\Fun\xml_file.xml");
            //XML_Format.DataForm(doc);
            
            Console.WriteLine("Hello World!");

            var watch = Stopwatch.StartNew();

            System.Xml.Serialization.XmlSerializer xmlSerializer = new XmlSerializer(typeof(Export));
            using System.IO.StreamReader streamReader = new System.IO.StreamReader(@"C:\Users\gaeta\Desktop\Fun\formattedFile.xml");
            var objt =(Export) xmlSerializer.Deserialize(streamReader);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            var offre601 = objt.StandardSalesItem.FirstOrDefault(x => x.Name == "601-TDG-NIVEAU-1");
        }
    }
}