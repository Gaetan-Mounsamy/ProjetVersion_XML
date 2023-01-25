using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddBusinessProperty
    {
        public static void NewBusinessProp(Export objt)
        {
            var targetStandardSalesItem = objt.StandardSalesItem.First(x => x.Name == "4269");
            
            var path = targetStandardSalesItem.BusinessPropertySets.BusinessPropertySet
                .First(x => x.Name == "bpsDescriptionOffreMetier").BusinessProperties.BusinessProperty;
            
            int targetLenght = path.Count;
            var newProperty = new BusinessProperty()
            {
                Name = "bpLibelleOffreCommerciale",
                SeqOrder = (targetLenght).ToString(),
                Values = new Values()
                {
                    Value = "Coucou toi, enfin moi"
                }
            };
            path.AddRange(new[] { newProperty });
        }
    }
}