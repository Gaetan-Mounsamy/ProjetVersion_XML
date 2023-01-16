using System;
using System.Xml;

namespace ProjetVersion_XML
{
    public class XML_Format
    {
        public static void DataForm(XmlDocument toFormat)
        {
            XmlTextWriter writer = new XmlTextWriter(@"C:\\Users\gaeta\Desktop\Fun\formattedFile.xml", null);
            writer.Formatting = Formatting.Indented;
            toFormat.Save(writer);
            Console.WriteLine("Formatage Done");
        }
    }
}