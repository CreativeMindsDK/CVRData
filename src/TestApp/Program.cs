using CreativeMinds.CVRData.Elasticsearch;
using Microsoft.Extensions.Configuration;
using Nest;
using System.Xml.Linq;
using CreativeMinds.CVRData.Elasticsearch.AppSettings;

namespace TestApp {

	internal class Program {

		static String[] companyTypes = new String[] { "a/s", "aps", "i/s" };
		static CreativeMinds.CVRData.Elasticsearch.SearchEngine searchEngine;

		static async Task Main(string[] args) {
			var builder = new ConfigurationBuilder()
					  .SetBasePath(Directory.GetCurrentDirectory())
					  .AddJsonFile("appsettings.json", optional: false)
					  .AddJsonFile($"appsettings.{Environment.UserName}.json", optional: true);

			IConfiguration config = builder.Build();
			CVRElasticsearchSettingsReader settings = new CVRElasticsearchSettingsReader();
			config.GetSection("CVRElasticsearch").Bind(settings);

			CancellationToken cancellationToken = new CancellationToken();

			//CreativeMinds.CVRData.Elasticsearch.SearchEngine search = new CreativeMinds.CVRData.Elasticsearch.SearchEngine(config.GetSection("CVRElasticsearch"));
			//var data = search.SearchForProductionUnitByNameAsync("Jonas Slyngbom Jørgensen", 10, cancellationToken).Result;
			//var data = search.SearchForCompanyByIdAsync(20213094, 10, cancellationToken).Result;
			//var data = search.SearchForProductionUnitByIdAsync(1016303093, 10, cancellationToken).Result;
			//var data = search.SearchForParticipantByNameAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;

			var raw = new RawHttpSearchEngine(settings);
			// "Opløst efter fussion"
			//var h = raw.SearchForCompanyByVatAsync("42140724", 10, cancellationToken);
			// error
			//var h = raw.SearchForCompanyByVatAsync("27125581", 10, cancellationToken);

			searchEngine = new CreativeMinds.CVRData.Elasticsearch.SearchEngine(settings);


			var res = await searchEngine.SearchForCompanyByIdAsync(27125581, 10, cancellationToken);


			String name = "Lagkagehuset - 291 Hellerup";
			String[] addresses = new String[] { "Strandvejen 100" };
			String postalCode = "2900";
			String city = "Hellerup";

			//await DoTheThingAsync(name, addresses, postalCode, city, cancellationToken);
		}

		//private static async Task<Object> DoTheThingAsync(String name, String[] addresses, String postalCode, String city, CancellationToken cancellationToken) {
		//	String[] parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		//	Boolean personHit = false;
		//	if (parts.Any(p => companyTypes.Contains(p) == true) == false) {
		//		ISearchResponse<CreativeMinds.CVRData.Elasticsearch.Dtos.Participants.ParticipantContainer> personResults = await searchEngine.SearchForParticipantByNameAsync(name, 1, cancellationToken);
		//		if (personResults.Hits.Any() == true) {
		//			if (personResults.Hits.First().Source.Participant.Names.First().Name.ToLowerInvariant() == name.ToLowerInvariant()) {
		//				return new SearchResult { RegistrantType = RegistrantType.Individual };
		//			}
		//		}
		//	}

		//	if (personHit == false) {
		//		Int32? houseNumber = null;
		//		String address = String.Empty;
		//		if (addresses != null && addresses.Any() == true && String.IsNullOrWhiteSpace(addresses.First()) == false) {
		//			parts = addresses.First().Split(' ', StringSplitOptions.RemoveEmptyEntries);
		//			if (parts.Any() == true) {
		//				Int32 tempNumber;
		//				if (Int32.TryParse(parts[parts.Length - 1], out tempNumber) == true) {
		//					houseNumber = tempNumber;
		//					address = String.Join(" ", parts.Take(parts.Length - 1));
		//				}
		//			}
		//		}

		//		var resultData2 = await searchEngine.SearchForProductionUnitByNameAsync(name, 5, cancellationToken);



		//		if (resultData2.Hits.Any() == true && resultData2.Documents.Any() == true) {
		//			var topHit = resultData2.Hits.First();
		//			var company = resultData2.Documents.First();

		//			if (String.IsNullOrWhiteSpace(address) == false && houseNumber.HasValue == true) {




		//			}
		//		}

		//		ISearchResponse<CompanyContainer> resultData = await searchEngine.SearchForCompanyByNameAndAddressAsync(name, address, houseNumber, 5, cancellationToken);
		//		if (resultData.Hits.Any() == true && resultData.Documents.Any() == true) {
		//			var topHit = resultData.Hits.First();
		//			var company = resultData.Documents.First();

		//			if (String.IsNullOrWhiteSpace(address) == false && houseNumber.HasValue == true) {
		//				if (company.Company.PhysicalAddress.Any(a => $"{address} {houseNumber.Value}".ToLowerInvariant().StartsWith($"{a.RoadName.ToLowerInvariant()} {a.HouseNumberFrom}") == true ||
		//					a.RoadName.ToLowerInvariant().StartsWith($"{address.ToLowerInvariant()} {houseNumber.Value}") == true) == true) {

		//					if (company.Company.BusinessInfo?.Any() == true) {
		//						BusinessInfoEntity? present = company.Company.BusinessInfo.GetPresent();
		//						if (present != null) {
		//							switch (present.BusinessTypeCode) {
		//								case (Int32)BusinessTypeCodes.ApS:
		//								case (Int32)BusinessTypeCodes.IvS:
		//								case (Int32)BusinessTypeCodes.AS:
		//									break;

		//								case (Int32)BusinessTypeCodes.Forening:
		//									break;
		//							}

		//							return new SearchResult { RegistrantType = businessType, CompanyId = $"DK{company.Company.Id}" };
		//						}
		//					}
		//				}
		//			}
		//		}
		//	}




		//	//var data = search.SearchForProductionUnitByNameAsync("Jonas Slyngbom Jørgensen", 10, cancellationToken).Result;
		//	//var data = search.SearchForCompanyByIdAsync(20213094, 10, cancellationToken).Result;
		//	//var data = search.SearchForProductionUnitByIdAsync(1016303093, 10, cancellationToken).Result;
		//	//var data = search.SearchForParticipantByNameAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;

		//	//var data = search.SearchForParticipantByIdAsync(4000391121, 10, cancellationToken).Result;



		//	//CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine search2 = new CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine(config.GetSection("CVRElasticsearch"));
		//	//Object resultData = search2.SearchForPersonAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;
		//}
	}
}