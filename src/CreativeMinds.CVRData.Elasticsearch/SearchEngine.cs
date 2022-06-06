using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CVRData.Elasticsearch {

	public class SearchEngine : ISearchEngine {
		protected readonly ICVRElasticsearchSettings settings;

		public SearchEngine(ICVRElasticsearchSettings settings) {
			this.settings = settings ?? throw new ArgumentNullException(nameof(settings));
		}

		public async Task<Object> SearchAsync(String companyName, CancellationToken cancellationToken) {
			String searchBody = @"{
 ""query"": {
  ""multi_match"": {
   ""query"": """ + name + @""",
   ""fields"": [
	""Vrvirksomhed.binavne.navn"",
	""Vrvirksomhed.navne.navn""
   ]
  }
 }
}
";

			HttpClient client = new HttpClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri(this.settings.Endpoint);
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			String base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.settings.Username}:{this.settings.Password}"));

			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "_search");
			request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
			request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

			HttpResponseMessage response = await client.SendAsync(request);

			String output = await response.Content.ReadAsStringAsync();

			//var resultData = JsonConvert.DeserializeObject(output);

			return output;
		}
	}
}
