using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class CompanyRelation : PeriodItemBase {
		[Number(Name = "cvrNummer")]
		public Int32 Id { get; set; }
	}
}
