using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using CreativeMinds.CVRData.Elasticsearch.Dtos;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public class SearchEngine : ISearchEngine {
		protected readonly IElasticClient elasticClient;

		public SearchEngine(IConfigurationSection settings) {
			Uri node = new Uri(settings["Endpoint"]);
			ConnectionSettings connectionSettings = new ConnectionSettings(node);
			connectionSettings.BasicAuthentication(settings["Username"], settings["Password"]);
			this.elasticClient = new ElasticClient(connectionSettings);
		}

		public SearchEngine(ICVRElasticsearchSettings settings) {
			Uri node = new Uri(settings.Endpoint);
			ConnectionSettings connectionSettings = new ConnectionSettings(node);
			connectionSettings.BasicAuthentication(settings.Username, settings.Password);
			this.elasticClient= new ElasticClient(connectionSettings);
		}

		public async Task<ISearchResponse<Dtos.CompanyContainer>> SearchForCompanyByIdAsync(Int32 companyId, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<Dtos.CompanyContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(maxHits)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(companyId.ToString())
								.Fields(f =>
									f.Field("Vrvirksomhed.cvrNummer")
					)))))
				);
		}

		public async Task<ISearchResponse<Dtos.CompanyContainer>> SearchForCompanyByNamesAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<Dtos.CompanyContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(maxHits)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(query)
								.Fields(f =>
									f.Field("Vrvirksomhed.binavne.navn")
										.Field("Vrvirksomhed.navne.navn")
					)))))
				);
		}

		public async Task<ISearchResponse<ProductionUnitContainer>> SearchForProductionUnitByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<Dtos.ProductionUnitContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(maxHits)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(query)
								.Fields(f =>
									f.Field("VrproduktionsEnhed.navne.navn")
					)))))
				);
		}
	}
}
