using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using CreativeMinds.CVRData.Elasticsearch.Dtos.Companies;
using CreativeMinds.CVRData.Elasticsearch.Dtos.Participants;
using CreativeMinds.CVRData.Elasticsearch.Dtos.ProductionUnits;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
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

		//public SearchEngine(ICVRElasticsearchSettings settings) {
		//	Uri node = new Uri(settings.Endpoint);
		//	ConnectionSettings connectionSettings = new ConnectionSettings(node);
		//	connectionSettings.BasicAuthentication(settings.Username, settings.Password);
		//	this.elasticClient = new ElasticClient(connectionSettings);
		//}

		public async Task<ISearchResponse<CompanyContainer>> SearchForCompanyByIdAsync(Int32 companyId, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<CompanyContainer>(s => s
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

		public async Task<ISearchResponse<CompanyContainer>> SearchForCompanyByNameAndAddressAsync(String name, String address, Int32? houseNumber, Int32 maxHits, CancellationToken cancellationToken) {
			if (String.IsNullOrWhiteSpace(address) == true) {
				return await this.elasticClient.SearchAsync<CompanyContainer>(s => s
						.Index("cvr-permanent")
						.From(0)
						.Size(maxHits)
						.Query(q => q.Bool(b =>
							b.Must(mu =>
								mu.MultiMatch(m =>
									m.Query(name)
									.Fields(f =>
										f.Field("Vrvirksomhed.binavne.navn")
											.Field("Vrvirksomhed.navne.navn")
						)))))
					);
			}
			else {
				var matches = new List<Func<QueryContainerDescriptor<CompanyContainer>, QueryContainer>> {
					mu => mu.Match(m => m.Field("Vrvirksomhed.beliggenhedsadresse.vejnavn").Query(address)),
					mu => mu.Match(m => m.Field("Vrvirksomhed.navne.navn").Query(name)),
					mu => mu.Match(m => m.Field("Vrvirksomhed.binavne.navn").Query(name))
				};

				if (houseNumber.HasValue == true) {
					matches.Add(
							mu => mu.Match(m => m.Field("Vrvirksomhed.beliggenhedsadresse.husnummerFra").Query(houseNumber.Value.ToString()))
						);
				}

				return await this.elasticClient.SearchAsync<CompanyContainer>(s => s
						.Index("cvr-permanent")
						.From(0)
						.Size(maxHits)
						.Query(q => q
							.Bool(b =>
								b.Should(matches)
							)
						)
					);
			}
		}

		public async Task<ISearchResponse<ParticipantContainer>> SearchForParticipantByIdAsync(Int64 unitId, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<ParticipantContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(maxHits)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(unitId.ToString())
								.Fields(f =>
									f.Field("Vrdeltagerperson.enhedsNummer")
					)))))
				);
		}

		public async Task<ISearchResponse<ParticipantContainer>> SearchForParticipantByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<ParticipantContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(maxHits)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(query)
								.Fields(f =>
									f.Field("Vrdeltagerperson.navne.navn")
					)))))
				);
		}

		public async Task<ISearchResponse<ProductionUnitContainer>> SearchForProductionUnitByIdAsync(Int64 productionUnitId, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<ProductionUnitContainer>(s => s
					.Index("cvr-permanent")
					.From(0)
					.Size(maxHits)
					.Query(q => q.Bool(b =>
						b.Must(mu =>
							mu.MultiMatch(m =>
								m.Query(productionUnitId.ToString())
								.Fields(f =>
									f.Field("VrproduktionsEnhed.pNummer")
					)))))
				);
		}

		public async Task<ISearchResponse<ProductionUnitContainer>> SearchForProductionUnitByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			return await this.elasticClient.SearchAsync<ProductionUnitContainer>(s => s
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
