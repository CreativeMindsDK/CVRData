using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using Nest;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public class SearchEngine : ISearchEngine {
		protected readonly ICVRElasticsearchSettings settings;

		public SearchEngine(ICVRElasticsearchSettings settings) {
			this.settings = settings ?? throw new ArgumentNullException(nameof(settings));
		}

		public async Task<Object> SearchAsync(String companyName, CancellationToken cancellationToken) {
			Uri node = new Uri(this.settings.Endpoint);
			ConnectionSettings settings = new ConnectionSettings(node);
			settings.BasicAuthentication(this.settings.Username, this.settings.Password);
			ElasticClient client = new ElasticClient(settings);
			ISearchResponse<Object> response = await client.SearchAsync<Object>(s => s
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
