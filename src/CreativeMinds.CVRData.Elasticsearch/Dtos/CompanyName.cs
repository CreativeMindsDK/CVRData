using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class CompanyName {
		[Text(Name = "navn")]
		public String Name { get; set; }
		[Object(Name = "periode")]
		public Period Period { get; set; }
		[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime LatestUpdated { get; set; }
	}
}
