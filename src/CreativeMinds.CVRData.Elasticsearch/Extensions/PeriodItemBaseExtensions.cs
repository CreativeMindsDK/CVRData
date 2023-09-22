using CreativeMinds.CVRData.Elasticsearch.Dtos;
using System;
using System.Linq;

namespace CreativeMinds.CVRData.Elasticsearch {

	public static class PeriodItemBaseExtensions {

		public static PeriodItemBase? GetPresent(this PeriodItemBase[] items) {
			return items.SingleOrDefault(i => i.Period.ValidFrom < DateTime.Now && i.Period.ValidTo.HasValue == false);
		}

		public static BusinessInfo? GetPresent(this BusinessInfo[] items) {
			return ((PeriodItemBase[])items).GetPresent() as BusinessInfo;
		}

		public static Location? GetPresent(this Location[] items) {
			return ((PeriodItemBase[])items).GetPresent() as Location;
		}

		public static CompanyName? GetPresent(this CompanyName[] items) {
			return ((PeriodItemBase[])items).GetPresent() as CompanyName;
		}
	}
}
