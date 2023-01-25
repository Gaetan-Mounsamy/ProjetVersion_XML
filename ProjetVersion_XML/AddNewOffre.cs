using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddNewOffre
    {
        public static void NewOffre(Export objt)
        {
            int targetLenght = objt.StandardSalesItem.Count;
            var salesItem = new StandardSalesItem()
            {
                Eligibility = "True",
                Name = "4269",
                Workspace = "wksHenner",
                
                
                Descriptions = new Descriptions()
                {
                    Description = new List<Description>()
                },
                
                
                BusinessPropertySets = new BusinessPropertySets()
                {
                    BusinessPropertySet = new List<BusinessPropertySet>()
                },
                
                Sparepartsviews = new Sparepartsviews()
                {
                    
                }
            };
            objt.StandardSalesItem.AddRange(new[] { salesItem });
            AddDescription.NewDescrip(objt);
            AddBusinessPropertySet.NewBP(objt);
            AddBusinessProperty.NewBusinessProp(objt);
        }
    }
}