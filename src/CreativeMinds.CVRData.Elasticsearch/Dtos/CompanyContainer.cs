using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class CompanyContainer {
		[Object(Name = "Vrvirksomhed")]
		public CompanyEntity Company { get; set; }
	}
}
