using System.Xml;

namespace ProjetVersion_XML
{
    public class MergeTypeAtt
    {
        public static void NewOffre()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\gaeta\Desktop\Fun\formattedFile.xml");

            foreach (XmlElement element in doc.DocumentElement.ChildNodes)
            {
                XmlAttribute mergeTypeAttribute = doc.CreateAttribute("mergeType");
                mergeTypeAttribute.Value = "new";
                element.Attributes.Append(mergeTypeAttribute);
            }
        }
    }
}