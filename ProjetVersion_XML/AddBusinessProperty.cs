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
            int targetLenght = targetStandardSalesItem.BusinessPropertySets.BusinessPropertySet.BusinessProperties.BusinessProperty.Count;
            var newProperty = new BusinessProperty()
            {
                Name = "",
                SeqOrder = (targetLenght).ToString(),
                Values = new Values()
                {
                    Value = ""
                }
            };
            targetStandardSalesItem.BusinessPropertySets.BusinessPropertySet.BusinessProperties.BusinessProperty
                .AddRange(new[] { newProperty });
        }
    }
}