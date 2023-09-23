using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class OrganisationEntity {
		[Number(Name = "enhedsNummerOrganisation")]
		public Int64 Id { get; set; }
		[Text(Name = "hovedtype")]
		public String Type { get; set; }
		[Nested(Name = "organisationsNavn")]
		public NameEntity[] Names { get; set; }
	}
}
