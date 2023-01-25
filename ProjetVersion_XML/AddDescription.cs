using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddDescription
    {
        public static void NewDescrip(Export objt)
        {
            var targetStandardSalesItem = objt.StandardSalesItem.First(x => x.Name == "4269");
            var newDescription = new Description()
            {
                Country = "FR",
                Language = "fr",
                Variant = ""
            };
            targetStandardSalesItem.Descriptions.Description.AddRange(new[] { newDescription });
        }
    }
}