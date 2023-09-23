using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.ProductionUnits {

	public class ProductionUnitContainer {
		[Object(Name = "VrproduktionsEnhed")]
		public ProductionUnitEntity ProductionUnit { get; set; }
	}
}
