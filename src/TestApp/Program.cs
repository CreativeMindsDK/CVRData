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

			CreativeMinds.CVRData.Elasticsearch.SearchEngine search = new CreativeMinds.CVRData.Elasticsearch.SearchEngine(config.GetSection("CVRElasticsearch"));
			ISearchResponse<CreativeMinds.CVRData.Elasticsearch.Dtos.CompanyContainer> data = search.SearchAsync("creativeminds", 10, cancellationToken).Result;

			CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine search2 = new CreativeMinds.CVRData.Elasticsearch.RawHttpSearchEngine(config.GetSection("CVRElasticsearch"));
			Object resultData = search2.SearchAsync("elgiganten", 10, cancellationToken).Result;
		}
	}
}