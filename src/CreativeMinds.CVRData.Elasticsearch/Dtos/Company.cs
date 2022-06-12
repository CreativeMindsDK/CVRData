using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class Company {
		[Number(Name = "cvrNummer")]
		public Int32 Id { get; set; }
		[Boolean(Name = "reklamebeskyttet")]
		public Boolean CommercialProtection { get; set; }
		[Nested(Name = "navne")]
		public CompanyName[] Names { get; set; }
		[Nest.Nested(Name = "binavne")]
		public CompanyName[] SecondaryNames { get; set; }
	}
}
