using CreativeMinds.CVRData.Elasticsearch;
using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using Microsoft.Extensions.Configuration;
using Nest;

namespace TestApp {

	internal class Program {

		static void Main(string[] args) {
			var builder = new ConfigurationBuilder()
					  .SetBasePath(Directory.GetCurrentDirectory())
					  .AddJsonFile("appsettings.json", optional: false)
					  .AddJsonFile($"appsettings.{Environment.UserName}.json", optional: true);

			IConfiguration config = builder.Build();

			CancellationToken cancellationToken = new CancellationToken();

			var settings = new CVRElasticsearchSettingsReader();
			config.GetSection("CVRElasticsearch").Bind(settings);


			//RawHttpSearchEngine raw = new RawHttpSearchEngine(settings);
			//var r = raw.SearchForCompanyByIdAsync(20213094, 10, cancellationToken).Result;


			CreativeMinds.CVRData.Elasticsearch.SearchEngine search = new CreativeMinds.CVRData.Elasticsearch.SearchEngine(settings);

			//var data = search.SearchForCompanyByNameAndAddressAsync("Lagkagehuset A/S", "Strandvejen", 100, 10 ,cancellationToken).Result;
			var data = search.SearchForCompanyByIdAsync(20213094, 5, cancellationToken).Result;

			var coy = data.Documents.First();
			var pars = coy.Company.Participants;
			var orgs = pars.Where(p => p.Organisations.Any(o => o.Type == "REGISTER"));



			//var data = search.SearchForCompanyByNameAndAddressAsync("Lagkagehuset A/S", "Strandvejen", 100, 10 ,cancellationToken).Result;
			data = search.SearchForCompanyByIdAsync(37659223, 5, cancellationToken).Result;

			coy = data.Documents.First();
			pars = coy.Company.Participants;
			orgs = pars.Where(p => p.Organisations.Any(o => o.Type == "REGISTER"));





			var data2 = search.SearchForProductionUnitByNameAsync("Jonas Slyngbom Jørgensen", 10, cancellationToken).Result;

			var data3 = search.SearchForCompanyByIdAsync(20213094, 10, cancellationToken).Result;

			//var data = search.SearchForProductionUnitByIdAsync(1016303093, 10, cancellationToken).Result;
			//var data = search.SearchForParticipantByNameAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;

			//var data = search.SearchForParticipantByIdAsync(4000391121, 10, cancellationToken).Result;



			//CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine search2 = new CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine(config.GetSection("CVRElasticsearch"));
			//Object resultData = search2.SearchForPersonAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;
		}
	}
}