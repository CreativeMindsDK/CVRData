using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public class Period {
		[Date(Name = "gyldigFra", Format = "yyyy-MM-dd")]
		public DateTime ValidFrom { get; set; }
		[Date(Name = "gyldigTil", Format = "yyyy-MM-dd")]
		public DateTime? ValidTo { get; set; }
	}
}
