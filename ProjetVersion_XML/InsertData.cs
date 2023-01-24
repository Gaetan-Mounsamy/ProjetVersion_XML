using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class InsertData
    {
        // Add data to the objt variable
        public static void UpdateFile(Export objt, XmlSerializer xmlSerializer)
        {
            objt.StandardSalesItem.LastOrDefault().Name = "2 eme essai";
            objt.StandardSalesItem.LastOrDefault().Workspace = "wksHenner";
            objt.StandardSalesItem.LastOrDefault().Links.Link = new List<Link>();



            Console.WriteLine(objt.StandardSalesItem.LastOrDefault().Links.Link.Count);
            
            
/*            
            objt.StandardSalesItem.LastOrDefault().Links.Link.LastOrDefault() = new Link
            {
                Quantity = 1,
                SeqOrder = 0,
                
            };
            

            objt.StandardSalesItem.LastOrDefault().Links.Link.LastOrDefault().Child = new Child
            {
                Name = "Coucou moi",
                ObjectType = null,
                Workspace = null
            };
*/
            // Serialize the objt variable back to XML
            using (FileStream fs = new FileStream(@"C:\Users\gaeta\Desktop\Fun\newtest.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, objt);
            }
        }
    }
}