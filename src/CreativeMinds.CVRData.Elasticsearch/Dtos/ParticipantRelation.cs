using Nest;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class ParticipantRelation {
		[Nested(Name = "deltager")]
		public Participant Participant { get; set; }
	}
}
