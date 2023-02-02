using System.Xml;

namespace ProjetVersion_XML
{
    public class MergeTypeAtt
    {
        public static void NewOffre()
        {
            /*
            
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\gaeta\Desktop\Fun\596.xml");
            
           
            foreach (XmlElement element in doc.DocumentElement.ChildNodes)
            {
                XmlAttribute mergeTypeAttribute = doc.CreateAttribute("mergeType");
                mergeTypeAttribute.Value = "new";
                element.Attributes.Append(mergeTypeAttribute);
            }
            
            
                   
            XmlAttribute attr = doc.CreateAttribute("mergeType");
            attr.Value = "";
            doc.DocumentElement.SetAttributeNode(attr);
            */
            
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\gaeta\Desktop\Fun\596.xml");
            
            XmlNodeList nodes = doc.GetElementsByTagName("*");

           
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes.Count != 0)
                {
                    XmlAttribute attribute = doc.CreateAttribute("mergeType");
                    attribute.Value = "IGNORE";
                    node.Attributes.Append(attribute);
                }
                
            }
            
            doc.Save(@"C:\Users\gaeta\Desktop\Fun\newbite.xml");

        }
    }
}