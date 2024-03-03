using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class BusinessStatus : PeriodItemBase {
		[Nested(Name = "status")]
		public String Status { get; set; }
		[Nested(Name = "sidstOpdateret")]
		public DateTime? LastUpdated { get; set; }
	}
}
