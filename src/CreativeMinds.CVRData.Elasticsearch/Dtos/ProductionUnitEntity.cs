using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class ProductionUnitEntity {
		[Number(Name = "pNummer")]
		public Int64 Id { get; set; }
		[Boolean(Name = "reklamebeskyttet")]
		public Boolean CommercialProtection { get; set; }
		[Nested(Name = "navne")]
		public NameEntity[] Names { get; set; }
		[Nested(Name = "beliggenhedsadresse")]
		public LocationEntity[] PhysicalAddress { get; set; }
		[Nested(Name = "virksomhedsrelation")]
		public CompanyRelationEntity[] CompanyRelations { get; set; }
	}
}
