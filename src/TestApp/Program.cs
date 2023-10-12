using CreativeMinds.CVRData.Elasticsearch;
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

			//CreativeMinds.CVRData.Elasticsearch.SearchEngine search = new CreativeMinds.CVRData.Elasticsearch.SearchEngine(config.GetSection("CVRElasticsearch"));
			//var data = search.SearchForProductionUnitByNameAsync("Jonas Slyngbom Jørgensen", 10, cancellationToken).Result;
			//var data = search.SearchForCompanyByIdAsync(20213094, 10, cancellationToken).Result;
			//var data = search.SearchForProductionUnitByIdAsync(1016303093, 10, cancellationToken).Result;
			//var data = search.SearchForParticipantByNameAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;

			//var data = search.SearchForParticipantByIdAsync(4000391121, 10, cancellationToken).Result;



			//CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine search2 = new CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine(config.GetSection("CVRElasticsearch"));
			//Object resultData = search2.SearchForPersonAsync("Steen Fredberg Tøttrup", 10, cancellationToken).Result;
		}
	}
}