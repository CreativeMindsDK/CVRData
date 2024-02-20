using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class AttributeEntity {
		[Nested(Name = "sekvensnr")]
		public Int32 SequenceNumber { get; set; }
		[Nested(Name = "type")]
		public String Type { get; set; }
		[Nested(Name = "vaerditype")]
		public String ValueType { get; set; }
		[Nested(Name = "vaerdier")]
		public ValueEntity[] Values { get; set; }
	}
}
