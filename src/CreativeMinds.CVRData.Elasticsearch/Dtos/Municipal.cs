using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class Municipal : PeriodItemBase {
		[Number(Name = "kommuneKode")]
		public Int32 MunicipalCode { get; set; }
		[Text(Name = "kommuneNavn")]
		public String Name { get; set; }
	}
}
