using CreativeMinds.CVRData.Elasticsearch.Dtos.ProductionUnits;
using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.Companies {

	public class CompanyEntity {
		[Number(Name = "cvrNummer")]
		public Int32 Id { get; set; }
		[Boolean(Name = "reklamebeskyttet")]
		public Boolean CommercialProtection { get; set; }
		[Nested(Name = "navne")]
		public NameEntity[] Names { get; set; }
		[Nested(Name = "binavne")]
		public NameEntity[] SecondaryNames { get; set; }
		[Nested(Name = "beliggenhedsadresse")]
		public LocationEntity[] PhysicalAddress { get; set; }
		[Nested(Name = "virksomhedsstatus")]
		public BusinessStatus[] BusinessStatus { get; set; }
		[Nested(Name = "virksomhedsform")]
		public BusinessInfoEntity[] BusinessInfo { get; set; }
		[Nested(Name = "deltagerRelation")]
		public ParticipantRelationEntity[] Participants { get; set; }
	}
}
