using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class ValueEntity : PeriodItemBase {
		[Text(Name = "vaerdi")]
		public String Value { get; set; }
	}
}
