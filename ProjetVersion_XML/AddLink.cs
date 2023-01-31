using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class AddLink
    {
        public static void NewLinkLigne(Export objt)
        {
            var targetStandardSalesItem = objt.StandardSalesItem.First(x => x.Name == "4269");
            int targetLenght = targetStandardSalesItem.Links.Link.Count;
            var newLink = new Link()
            {
                Quantity = "1",
                SeqOrder = (targetLenght).ToString(),
                
                BpsValuesList = new BpsValuesList()
                {
                    BpsValues = new BpsValues()
                    {
                        Name = "BpsGarantieTDG",
                        Workspace = "wksHenner",
                        
                        BusinessProperties = new BusinessProperties()
                        {
                            BusinessProperty = new List<BusinessProperty>()
                        }
                        
                    }
                    
                    
                },
                
                Child = new Child()
                {
                    Name = "MyNewProduct",
                    ObjectType = "SI",
                    Workspace = "wksHenner"
                },
                
                ParameterIdent = new ParameterIdent()
                {
                    Class = "ProductLink",
                    ParameterType = "LinkType",
                    Name = "lienGarantiePrestation",
                    Workspace = "wksHenner"
                },
                
            };
            
            targetStandardSalesItem.Links.Link.AddRange(new[] { newLink });
            AddLinkBp.NewBusinessProp(objt);

        }
    }
}