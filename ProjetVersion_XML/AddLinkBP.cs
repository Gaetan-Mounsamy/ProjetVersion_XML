using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddLinkBp
    {
        public static void NewBusinessProp(Export objt)
        {
            var targetStandardSalesItem = objt.StandardSalesItem.First(x => x.Name == "4269");

            var path = targetStandardSalesItem.Links.Link.First(ord => ord.SeqOrder == "0")
                .BpsValuesList.BpsValues.BusinessProperties.BusinessProperty;
            
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