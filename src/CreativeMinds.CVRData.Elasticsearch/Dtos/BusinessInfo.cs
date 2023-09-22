using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class BusinessInfo : PeriodItemBase {
		[Nested(Name = "virksomhedsformkode")]
		public Int32 BusinessTypeCode { get; set; }
		[Nested(Name = "kortBeskrivelse")]
		public String ShortDescription { get; set; }
		[Nested(Name = "langBeskrivelse")]
		public String Description { get; set; }
		[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime LatestUpdated { get; set; }
	}
}
