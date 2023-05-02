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
		[Nested(Name = "binavne")]
		public CompanyName[] SecondaryNames { get; set; }
		//[Nested(Name = "beliggenhedsadresse")]
		//public Location[] PhysicalAddress { get; set; }
	}
}
