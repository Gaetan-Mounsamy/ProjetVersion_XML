using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddBusinessPropertySet
    {
        public static void NewBP(Export objt)
        {
            var targetStandardSalesItem = objt.StandardSalesItem.First(x => x.Name == "4269");
            
            var path = targetStandardSalesItem.BusinessPropertySets.BusinessPropertySet;
                
            var businessPropSet = new BusinessPropertySet()
            {
                Name = "bpsDescriptionOffreMetier",
                Workspace = "wksHenner",
                BusinessProperties = new BusinessProperties()
                {
                    BusinessProperty = new List<BusinessProperty>()
                }
            };
            path.AddRange(new[] { businessPropSet });
            
        }
    }
}