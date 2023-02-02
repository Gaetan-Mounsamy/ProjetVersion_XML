using System;
using System.Xml;

namespace ProjetVersion_XML
{
    public class MergeTypeAtt
    {
        //public static string NewOffre(string pathFile)
        public static void NewOffre(string pathFile)

        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathFile);
            
            XmlNodeList nodes = doc.GetElementsByTagName("*");

           
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes.Count != 0)
                {
                    if ((node.Name == "importExportMetadata") || (node.Name == "export") || (node.Name == "version") )
                    {

                    }
                    else
                    {
                        XmlAttribute attribute = doc.CreateAttribute("mergeType");
                        attribute.Value = "IGNORE";
                        node.Attributes.Append(attribute);
                    }
                }
                
            }
            
            doc.Save(pathFile);
            //string newPath = @"C:\Users\gaeta\Desktop\Fun\newbite.xml";
            //doc.Save(newPath);
            //return newPath;

        }
    }
}