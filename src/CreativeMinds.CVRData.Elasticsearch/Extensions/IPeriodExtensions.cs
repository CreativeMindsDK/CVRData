using CreativeMinds.CVRData.Elasticsearch.Dtos;
using System;
using System.Linq;

namespace CreativeMinds.CVRData.Elasticsearch {

	public static class IPeriodExtensions {

		public static IPeriodItem? GetPresent(this IPeriodItem[] items) {
			return items.SingleOrDefault(i => i.Period.ValidFrom < DateTime.Now && i.Period.ValidTo.HasValue == false);
		}
	}
}
