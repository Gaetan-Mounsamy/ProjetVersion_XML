using System.Collections.Generic;
using System.Linq;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddSalesItem
    {
        public static void NewSaleItem(Export objt)
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
                    
                    BusinessPropertySet = new BusinessPropertySet()
                    {
                        Name = "BpsXXX",
                        Workspace = "wksHenner",
                        BusinessProperties = new BusinessProperties()
                        {
                            BusinessProperty = new List<BusinessProperty>()
                        }
                    }
                    
                },
                
                Sparepartsviews = new Sparepartsviews()
                {
                    
                }
            };
            objt.StandardSalesItem.AddRange(new[] { salesItem });
            AddDescription.NewDescrip(objt);
            //AddBusinessPropertySet.NewBusinessPropSet(objt);
            AddBusinessProperty.NewBusinessProp(objt);

        }
    }
}