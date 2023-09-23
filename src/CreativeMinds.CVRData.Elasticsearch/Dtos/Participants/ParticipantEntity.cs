using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.Participants {

	public class ParticipantEntity {
		[Number(Name = "forretningsnoegle")]
		public Int64? BusinessKey { get; set; }
		[Date(Name = "sidstIndlaest", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastChanged { get; set; }
		[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastUpdated { get; set; }
		[Nested(Name = "navne")]
		public NameEntity[] Names { get; set; }
	}
}
