using CreativeMinds.CVRData.Elasticsearch.Dtos.Companies;
using CreativeMinds.CVRData.Elasticsearch.Dtos.Participants;
using CreativeMinds.CVRData.Elasticsearch.Dtos.ProductionUnits;
using Nest;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public interface ISearchEngine {
		Task<ISearchResponse<CompanyContainer>> SearchForCompanyByNamesAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<CompanyContainer>> SearchForCompanyByIdAsync(Int32 companyId, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<ProductionUnitContainer>> SearchForProductionUnitByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<ProductionUnitContainer>> SearchForProductionUnitByIdAsync(Int64 productionUnitId, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<Dtos.Participants.ParticipantContainer>> SearchForParticipantByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
		Task<ISearchResponse<Dtos.Participants.ParticipantContainer>> SearchForParticipantByIdAsync(Int64 unitId, Int32 maxHits, CancellationToken cancellationToken);
	}
}
