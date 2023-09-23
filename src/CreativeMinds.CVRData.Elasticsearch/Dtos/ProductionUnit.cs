using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class ProductionUnit {
		[Number(Name = "pNummer")]
		public Int64 Id { get; set; }
		[Boolean(Name = "reklamebeskyttet")]
		public Boolean CommercialProtection { get; set; }
		[Nested(Name = "navne")]
		public CompanyName[] Names { get; set; }
		[Nested(Name = "beliggenhedsadresse")]
		public Location[] PhysicalAddress { get; set; }
		[Nested(Name = "virksomhedsrelation")]
		public CompanyRelation[] CompanyRelations { get; set; }
	}
}
