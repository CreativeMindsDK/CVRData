using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using Nest;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public class SearchEngine : ISearchEngine {
		protected readonly IElasticClient elasticClient;

		public SearchEngine(ICVRElasticsearchSettings settings) {
			Uri node = new Uri(settings.Endpoint);
			ConnectionSettings connectionSettings = new ConnectionSettings(node);
			connectionSettings.BasicAuthentication(settings.Username, settings.Password);
			this.elasticClient= new ElasticClient(connectionSettings);
		}

		public async Task<Object> SearchAsync(String companyName, CancellationToken cancellationToken) {
			ISearchResponse<Dtos.CompanyContainer> response = await this.elasticClient.SearchAsync<Dtos.CompanyContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(10)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(companyName)
								.Fields(f => 
									f.Field("Vrvirksomhed.binavne.navn")
										.Field("Vrvirksomhed.navne.navn")
					)))))
				);

			return response;
		}
	}
}
