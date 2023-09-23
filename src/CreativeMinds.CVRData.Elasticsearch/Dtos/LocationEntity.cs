using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class LocationEntity : PeriodItemBase {
		[Text(Name = "landekode")]
		public String CountryCode { get; set; }
		[Text(Name = "fritekst")]
		public String Freetext { get; set; }
		[Number(Name = "vejkode")]
		public Int32? RoadCode { get; set; }
		[Object(Name = "kommune")]
		public MunicipalEntity Municipal { get; set; }
		[Text(Name = "vejnavn")]
		public String RoadName { get; set; }
		[Number(Name = "postnummer")]
		public Int32? PostalCode { get; set; }
		[Text(Name = "postdistrikt")]
		public String PostalDistrict { get; set; }
		[Text(Name = "husnummerFra")]
		public Int32? HouseNumberFrom { get; set; }
		[Text(Name = "husnummerTil")]
		public Int32? HouseNumberTo { get; set; }
		[Text(Name = "etage")]
		public String Floor { get; set; }
		[Text(Name = "sidedoer")]
		public String Door { get; set; }
		[Text(Name = "bynavn")]
		public String City { get; set; }
		[Text(Name = "adresseId")]
		public String AddressId { get; set; }
		[Date(Name = "sidstValideret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastValidated { get; set; }
		[Text(Name = "bogstavFra")]
		public String LetterFrom { get; set; }
		[Text(Name = "bogstavTil")]
		public String LetterTo { get; set; }
		[Text(Name = "conavn")]
		public String CoName { get; set; }
		[Text(Name = "postboks")]
		public String POBox { get; set; }

	}
}
