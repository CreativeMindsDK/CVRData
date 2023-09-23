using Nest;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public interface ISearchEngine {
		Task<ISearchResponse<Dtos.CompanyContainer>> SearchForCompanyByNamesAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<Dtos.CompanyContainer>> SearchForCompanyByIdAsync(Int32 companyId, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<Dtos.ProductionUnitContainer>> SearchForProductionUnitByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
	}
}
