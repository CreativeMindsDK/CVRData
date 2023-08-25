using Nest;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public interface ISearchEngine {
		Task<ISearchResponse<Dtos.CompanyContainer>> SearchAsync(String companyName, Int32 maxHits, CancellationToken cancellationToken);
	}
}
