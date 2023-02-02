using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            string originPath = @"C:\Users\gaeta\Desktop\Fun\xml_file.xml";
            MergeTypeAtt.NewOffre(originPath);
            
            var watch = Stopwatch.StartNew();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Export));
            using System.IO.StreamReader streamReader = new System.IO.StreamReader(originPath);

            //Casting operation, permet de convertir le resultat de Deserialize
                // Dans ce cas, la méthode Deserialize renvoie un objet, et cet objet est converti au type Export.
                // Cette opération permet d'accéder à l'objet et de le manipuler en tant qu'instance de la classe
                // Export, plutôt que comme un simple objet général.
            var objt = (Export) xmlSerializer.Deserialize(streamReader);
            
            
            //deserialize the XML data into an object of type Export
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            var filtre = objt.StandardSalesItem.FirstOrDefault(x => x.Name == "601");
            var offrecomplete = objt.StandardSalesItem.Where(x => x.Name.Contains("596"));
            
            //AddSalesItem.NewSaleItem(objt);
            CreateNewOffre.NewOffre(objt);
            
            using System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\gaeta\Desktop\Fun\empty.xml");
            xmlSerializer.Serialize(writer, objt);
            
            var tentative = filtre.Links.Link.Where(x => x.ParameterIdent.Name == "lienOffreFormule");
            
            List<string> formuleoffre = new List<string>();
            foreach (var zelda in tentative)
            {
                formuleoffre.Add(zelda.Child.Name);
            }
            
        }
    }
}