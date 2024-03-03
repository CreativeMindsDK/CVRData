using CreativeMinds.CVRData.Elasticsearch.Dtos;
using System;
using System.Linq;

namespace CreativeMinds.CVRData.Elasticsearch {

	public static class PeriodItemBaseExtensions {

		public static PeriodItemBase? GetPresent(this PeriodItemBase[] items) {
			PeriodItemBase output = items.SingleOrDefault(i => i.Period.ValidFrom < DateTime.Now && i.Period.ValidTo.HasValue == false);
			if (output != null) {
				return output;
			}
			return items.SingleOrDefault(i => i.Period.ValidFrom.HasValue == false && i.Period.ValidTo.HasValue == false);
		}

		public static PeriodItemBase? GetLatest(this PeriodItemBase[] items) {
			var present = items.GetPresent();
			if (present != null) {
				return present;
			}

			return items.OrderByDescending(i => i.Period.ValidFrom.Value).FirstOrDefault();
		}

		public static BusinessInfoEntity? GetPresent(this BusinessInfoEntity[] items) {
			return ((PeriodItemBase[])items).GetPresent() as BusinessInfoEntity;
		}

		public static BusinessStatus? GetPresent(this BusinessStatus[] items) {
			return ((PeriodItemBase[])items).GetPresent() as BusinessStatus;
		}

		public static BusinessStatus? GetLatest(this BusinessStatus[] items) {
			return ((PeriodItemBase[])items).GetPresent() as BusinessStatus;
		}

		public static LocationEntity? GetPresent(this LocationEntity[] items) {
			return ((PeriodItemBase[])items).GetPresent() as LocationEntity;
		}

		public static NameEntity? GetPresent(this NameEntity[] items) {
			return ((PeriodItemBase[])items).GetPresent() as NameEntity;
		}
	}
}
