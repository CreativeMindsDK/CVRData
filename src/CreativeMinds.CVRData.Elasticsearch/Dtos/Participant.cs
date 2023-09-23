using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class Participant {
		[Number(Name = "enhedsNummer")]
		public Int64 Id { get; set; }
		[Text(Name = "enhedstype")]
		public String Type { get; set; }
		[Number(Name = "forretningsnoegle")]
		public Int64? BusinessKey { get; set; }
		[Date(Name = "sidstIndlaest", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastChanged { get; set; }
		[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastUpdated { get; set; }
		[Nested(Name = "navne")]
		public CompanyName[] Names { get; set; }
	}
}
