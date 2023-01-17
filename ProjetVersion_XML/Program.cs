using System;
using System.Collections.Generic;
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
            
                /*
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Users\gaeta\Desktop\Fun\xml_file.xml");
            //XML_Format.DataForm(doc);
                */

            var watch = Stopwatch.StartNew();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Export));
            using System.IO.StreamReader streamReader = new System.IO.StreamReader(@"C:\Users\gaeta\Desktop\Fun\formattedFile.xml");
                
            //Casting operation, permet de convertir le resultat de Deserialize
                // Dans ce cas, la méthode Deserialize renvoie un objet, et cet objet est converti au type Export.
                // Cette opération permet d'accéder à l'objet et de le manipuler en tant qu'instance de la classe
                // Export, plutôt que comme un simple objet général.
                

            var objt = (Export) xmlSerializer.Deserialize(streamReader);
                //deserialize the XML data into an object of type Export
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            var filtre = objt.StandardSalesItem.FirstOrDefault(x => x.Name == "601-TDG-NIVEAU-1");
            //Console.WriteLine(filtre.Links.Link[0].Child.Name);
            
/*
            var testons = filtre.Links;
            testons.Link[0].Child.Name = "COUCOU DU CON";
            testons.Link[1].Child.Name = "CONNARD VA";
            
            
            
            StandardSalesItem salesItem = new StandardSalesItem();
            salesItem.Name = "c'est des test, tqt";
            salesItem.Eligibility = "true";
            salesItem.Links = new Links();
            salesItem.Links.Link = new List<Link>();
            salesItem.Links.Link.Child = new Child();
            salesItem.Links.Link[0].Child.Name = "COUCOU DU CON";
            

            StandardSalesItem salesItem = new StandardSalesItem();
            salesItem.Name = "coucouc test";
            salesItem.Workspace = "auto";
            */
        }
    }
}