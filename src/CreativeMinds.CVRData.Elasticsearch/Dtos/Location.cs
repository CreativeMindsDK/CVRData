using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class Location {
		[Text(Name = "landekode")]
		public String CountryCode { get; set; }
		[Text(Name = "fritekst")]
		public String Freetext { get; set; }
		[Number(Name = "vejkode")]
		public Int32 RoadCode { get; set; }
		[Object(Name = "kommune")]
		public Municipal Municipal { get; set; }
		[Number(Name = "husnummerFra")]
		public Int32 Number { get; set; }
		[Text(Name = "vejnavn")]
		public String RoadName { get; set; }
		[Number(Name = "postnummer")]
		public Int32 PostalCode { get; set; }
		[Text(Name = "postdistrikt")]
		public String PostalDistrict { get; set; }
	}
}
