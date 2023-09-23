using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.Companies {

	public class CompanyContainer {
		[Object(Name = "Vrvirksomhed")]
		public CompanyEntity Company { get; set; }
	}
}
