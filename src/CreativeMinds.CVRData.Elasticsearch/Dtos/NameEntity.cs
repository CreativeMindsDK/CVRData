using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class NameEntity : PeriodItemBase {
		[Text(Name = "navn")]
		public String Name { get; set; }
		[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LatestUpdated { get; set; }
	}
}
