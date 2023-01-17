using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestImportXml
{
	[XmlRoot(ElementName="description")]
	public class Description {
		[XmlAttribute(AttributeName="country")]
		public string Country { get; set; }
		[XmlAttribute(AttributeName="language")]
		public string Language { get; set; }
		[XmlAttribute(AttributeName="variant")]
		public string Variant { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="descriptions")]
	public class Descriptions {
		[XmlElement(ElementName="description")]
		public List<Description> Description { get; set; }
	}

	[XmlRoot(ElementName = "values")]
	public class Values
	{
		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "businessProperty")]
	public class BusinessProperty
	{
		[XmlElement(ElementName = "seqOrder")]
		public string SeqOrder { get; set; }
		[XmlElement(ElementName = "values")]
		public Values Values { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "businessProperties")]
	public class BusinessProperties
	{
		[XmlElement(ElementName = "businessProperty")]
		public List<BusinessProperty> BusinessProperty { get; set; }
	}

	[XmlRoot(ElementName = "businessPropertySet")]
	public class BusinessPropertySet
	{
		[XmlElement(ElementName = "businessProperties")]
		public BusinessProperties BusinessProperties { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "workspace")]
		public string Workspace { get; set; }
	}

	[XmlRoot(ElementName = "businessPropertySets")]
	public class BusinessPropertySets
	{
		[XmlElement(ElementName = "businessPropertySet")]
		public BusinessPropertySet BusinessPropertySet { get; set; }
	}

	[XmlRoot(ElementName = "child")]
	public class Child
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "objectType")]
		public string ObjectType { get; set; }
		[XmlAttribute(AttributeName = "workspace")]
		public string Workspace { get; set; }
	}

	[XmlRoot(ElementName = "parameterIdent")]
	public class ParameterIdent
	{
		[XmlAttribute(AttributeName = "class")]
		public string Class { get; set; }
		[XmlAttribute(AttributeName = "parameterType")]
		public string ParameterType { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "workspace")]
		public string Workspace { get; set; }
	}

	[XmlRoot(ElementName = "link")]
	public class Link
	{
		[XmlElement(ElementName = "child")]
		public Child Child { get; set; }
		[XmlElement(ElementName = "parameterIdent")]
		public ParameterIdent ParameterIdent { get; set; }
		[XmlAttribute(AttributeName = "quantity")]
		public string Quantity { get; set; }
		[XmlAttribute(AttributeName = "seqOrder")]
		public string SeqOrder { get; set; }
		[XmlElement(ElementName = "bpsValuesList")]
		public BpsValuesList BpsValuesList { get; set; }
	}

	[XmlRoot(ElementName = "bpsValues")]
	public class BpsValues
	{
		[XmlElement(ElementName = "businessProperties")]
		public BusinessProperties BusinessProperties { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "workspace")]
		public string Workspace { get; set; }
	}

	[XmlRoot(ElementName = "bpsValuesList")]
	public class BpsValuesList
	{
		[XmlElement(ElementName = "bpsValues")]
		public BpsValues BpsValues { get; set; }
	}

	[XmlRoot(ElementName = "links")]
	public class Links
	{
		[XmlElement(ElementName = "link")]
		public List<Link> Link { get; set; }
	}

	[XmlRoot(ElementName = "standardSalesItem")]
	public class StandardSalesItem
	{
		[XmlElement(ElementName = "descriptions")]
		public Descriptions Descriptions { get; set; }
		[XmlElement(ElementName = "businessPropertySets")]
		public BusinessPropertySets BusinessPropertySets { get; set; }
		[XmlElement(ElementName = "links")]
		public Links Links { get; set; }
		[XmlElement(ElementName = "sparepartsviews")]
		public Sparepartsviews Sparepartsviews { get; set; }
		[XmlElement(ElementName = "manufacturingLinks")]
		public string ManufacturingLinks { get; set; }
		[XmlElement(ElementName = "routingLinks")]
		public string RoutingLinks { get; set; }
		[XmlAttribute(AttributeName = "eligibility")]
		public string Eligibility { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "workspace")]
		public string Workspace { get; set; }
	}

	[XmlRoot(ElementName = "sparepartsview")]
	public class Sparepartsview
	{
		[XmlElement(ElementName = "hotspots")]
		public string Hotspots { get; set; }
	}

	[XmlRoot(ElementName = "sparepartsviews")]
	public class Sparepartsviews
	{
		[XmlElement(ElementName = "sparepartsview")]
		public Sparepartsview Sparepartsview { get; set; }
	}

	[XmlRoot(ElementName = "importExportMetadata")]
	public class ImportExportMetadata
	{
		[XmlElement(ElementName = "exportDate")]
		public string ExportDate { get; set; }
		[XmlElement(ElementName = "exportType")]
		public string ExportType { get; set; }
		[XmlElement(ElementName = "version")]
		public Version Version { get; set; }
		[XmlAttribute(AttributeName = "workspaceName")]
		public string WorkspaceName { get; set; }
	}

	[XmlRoot(ElementName = "version")]
	public class Version
	{
		[XmlElement(ElementName = "fixNumber")]
		public string FixNumber { get; set; }
		[XmlElement(ElementName = "versionDescr")]
		public string VersionDescr { get; set; }
		[XmlElement(ElementName = "versionLabel")]
		public string VersionLabel { get; set; }
		[XmlAttribute(AttributeName = "isWorking")]
		public string IsWorking { get; set; }
		[XmlAttribute(AttributeName = "versionDate")]
		public string VersionDate { get; set; }
	}

	[XmlRoot(ElementName = "export")]
	public class Export
	{
		[XmlElement(ElementName = "importExportMetadata")]
		public ImportExportMetadata ImportExportMetadata { get; set; }
		
		[XmlElement(ElementName = "standardSalesItem")]
		public List<StandardSalesItem> StandardSalesItem { get; set; }

		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
	}
	
	[XmlRoot(ElementName="rmo")]
	public class Rmo {
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="workspace")]
		public string Workspace { get; set; }
	}
	
	[XmlRoot(ElementName="businessValue")]
	public class BusinessValue 
	{
		[XmlElement(ElementName="descriptions")]
		public Descriptions Descriptions { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="workspace")]
		public string Workspace { get; set; }
	}
	
	[XmlRoot(ElementName="productCollection")]
	public class ProductCollection 
	{
		[XmlElement(ElementName="descriptions")]
		public Descriptions Descriptions { get; set; }
		[XmlElement(ElementName="links")]
		public Links Links { get; set; }
		[XmlElement(ElementName="labelLinks")]
		public string LabelLinks { get; set; }
		[XmlElement(ElementName="labels")]
		public string Labels { get; set; }
		[XmlElement(ElementName="naLinks")]
		public string NaLinks { get; set; }
		[XmlElement(ElementName="searchBpss")]
		public string SearchBpss { get; set; }
		[XmlElement(ElementName="teaserLinks")]
		public string TeaserLinks { get; set; }
		[XmlAttribute(AttributeName="isRoot")]
		public string IsRoot { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="workspace")]
		public string Workspace { get; set; }
		[XmlElement(ElementName="collectionLinks")]
		public CollectionLinks CollectionLinks { get; set; }
		[XmlElement(ElementName="businessPropertySets")]
		public BusinessPropertySets BusinessPropertySets { get; set; }
		[XmlElement(ElementName="rmo")]
		public Rmo Rmo { get; set; }
	}
	
	[XmlRoot(ElementName="collectionLink")]
	public class CollectionLink 
	{
		[XmlElement(ElementName="child")]
		public Child Child { get; set; }
		[XmlAttribute(AttributeName="seqOrder")]
		public string SeqOrder { get; set; }
	}

	[XmlRoot(ElementName="collectionLinks")]
	public class CollectionLinks 
	{
		[XmlElement(ElementName="collectionLink")]
		public List<CollectionLink> CollectionLink { get; set; }
	}
}
