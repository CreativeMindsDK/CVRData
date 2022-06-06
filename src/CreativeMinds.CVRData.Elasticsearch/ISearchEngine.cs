using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public interface ISearchEngine {
		Task<Object> SearchAsync(String companyName, CancellationToken cancellationToken);

	}
}
