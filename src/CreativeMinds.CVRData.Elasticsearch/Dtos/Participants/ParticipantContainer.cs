using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.Participants {

	public class ParticipantContainer {
		[Nested(Name = "Vrdeltagerperson")]
		public ParticipantEntity Participant { get; set; }
	}
}
