using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CreativeMinds.CVRData.Elasticsearch {

	public static class ServiceCollectionExtensions {

		public static IServiceCollection AddCVRElasticSearch(this IServiceCollection services, IConfiguration configuration) {
			services.Configure<CVRElasticsearchSettingsReader>(configuration.GetSection("CVRElasticsearch"));
			services.AddTransient<ICVRElasticsearchSettings, CVRElasticsearchSettingsBridge>();

			//services.AddScoped<ISearchEngine, RawHttpSearchEngine>();
			services.AddSingleton<ISearchEngine, SearchEngine>();

			return services;
		}
	}
}