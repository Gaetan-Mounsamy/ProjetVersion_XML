using System.Collections.Generic;
using System.Linq;
using System.Xml;
using TestImportXml;

namespace ProjetVersion_XML
{
    public class CreateNewOffre
    {
        public static void NewOffre(Export objt)
        {
            int targetLenght = objt.StandardSalesItem.Count;
            
            var offreProp = new StandardSalesItem()
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
                
                Links = new Links()
                {
                    Link = new List<Link>()
                },
                
                
                Sparepartsviews = new Sparepartsviews(),

                
                ManufacturingLinks = new ManufacturingLinks(),

                
                RoutingLinks = new RoutingLinks()
                
                
            };
            
            objt.StandardSalesItem.AddRange(new[] { offreProp });
            //faudra modifier les fonctions pour accepeter des parametres d'entree pour moduler en fonction
            // de ce qu'on ajoute + faire des boucles dans le cas d'ajout multiple, aka link
            AddDescription.NewDescrip(objt);
            AddBusinessPropertySet.NewBP(objt);
            AddBusinessProperty.NewBusinessProp(objt);
            AddLink.NewLinkLigne(objt);
            //objt.StandardSalesItem.Add(new StandardSalesItem("NewChild", "new content"));

        }
    }
}