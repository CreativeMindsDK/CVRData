using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class Municipal {
		[Number(Name = "kommuneKode")]
		public Int32 MunicipalCode { get; set; }
		[Text(Name = "kommuneNavn")]
		public String Name { get; set; }
		//[Object(Name = "periode")]
		//public Period Period { get; set; }
		//[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		//public DateTime LatestUpdated { get; set; }
	}
}
