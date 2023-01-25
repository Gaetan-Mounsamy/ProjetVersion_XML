using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddBusinessPropertySet
    {
        public static void NewBusinessPropSet(Export objt)
        {
            var targetStandardSalesItem = objt.StandardSalesItem.First(x => x.Name == "4269");
            var businessPropSet = new BusinessPropertySet()
            {
                Name = "BpsPrestations",
                Workspace = "wksHenner",
                BusinessProperties = new BusinessProperties()
                {
                            
                }
            };
            //targetStandardSalesItem.BusinessPropertySets.BusinessPropertySet.AddRange(new[] { businessPropSet });
            
        }
    }
}