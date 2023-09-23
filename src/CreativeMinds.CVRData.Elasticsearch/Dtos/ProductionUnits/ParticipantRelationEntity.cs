using Nest;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.ProductionUnits {

	public class ParticipantRelationEntity {
		[Nested(Name = "deltager")]
		public ParticipantEntity Participant { get; set; }
	}
}
