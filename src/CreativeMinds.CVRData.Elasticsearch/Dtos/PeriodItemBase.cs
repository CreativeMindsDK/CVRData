using Nest;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public abstract class PeriodItemBase {
		[Object(Name = "periode")]
		public PeriodEntity Period { get; set; }
	}
}
