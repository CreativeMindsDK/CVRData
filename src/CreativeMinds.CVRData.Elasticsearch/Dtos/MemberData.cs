using Nest;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class MemberData {
		[Nested(Name = "attributter")]
		public AttributeEntity[] Attributes { get; set; }
	}
}
