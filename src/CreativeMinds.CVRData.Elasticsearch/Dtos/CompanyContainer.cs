using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class CompanyContainer {
		[Object(Name = "Vrvirksomhed")]
		public Company Company { get; set; }
	}
}
