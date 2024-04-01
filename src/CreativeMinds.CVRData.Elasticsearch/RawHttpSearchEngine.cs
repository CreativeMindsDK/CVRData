using CreativeMinds.CVRData.Elasticsearch.AppSettings;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Nest;

namespace CreativeMinds.CVRData.Elasticsearch {

	public class RawHttpSearchEngine /*: ISearchEngine*/ {
		private String endpoint;
		private String username;
		private String password;

		public RawHttpSearchEngine(ICVRElasticsearchSettings settings) {
			this.endpoint = settings.Endpoint;
			this.username= settings.Username;
			this.password = settings.Password;
		}

		public RawHttpSearchEngine(IConfigurationSection settings) {
			this.endpoint = settings["Endpoint"];
			this.username= settings["Username"];
			this.password = settings["Password"];
		}

		public async Task<Object> SearchForProductionUnitAsync(String companyName, Int32 maxHits, CancellationToken cancellationToken) {
			String searchBody = @"{
 ""query"": {
  ""multi_match"": {
   ""query"": """ + companyName + @""",
   ""fields"": [
	""VrproduktionsEnhed.navne.navn""
   ]
  }
 }
}
";

			HttpClient client = new HttpClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri($"{this.endpoint}/cvr-permanent/produktionsenhed");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			String base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.username}:{this.password}"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "_search");
				request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
				request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String output = await response.Content.ReadAsStringAsync();

				return JsonConvert.DeserializeObject(output);
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		public async Task<Object> SearchForCompanyAsync(String companyName, Int32 maxHits, CancellationToken cancellationToken) {
			String searchBody = @"{
 ""query"": {
  ""multi_match"": {
   ""query"": """ + companyName + @""",
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
			client.BaseAddress = new Uri($"{this.endpoint}/cvr-permanent/virksomhed");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			String base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.username}:{this.password}"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "_search");
				request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
				request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String output = await response.Content.ReadAsStringAsync();

				return JsonConvert.DeserializeObject(output);
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		public async Task<Object> SearchForCompanyByVatAsync(String vatNumber, Int32 maxHits, CancellationToken cancellationToken) {
			String searchBody = @"{
 ""query"": {
  ""multi_match"": {
   ""query"": """ + vatNumber + @""",
   ""fields"": [
	""Vrvirksomhed.cvrNummer""
   ]
  }
 }
}
";

			HttpClient client = new HttpClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri($"{this.endpoint}/cvr-permanent/virksomhed");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			String base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.username}:{this.password}"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "_search");
				request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
				request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String output = await response.Content.ReadAsStringAsync();

				return JsonConvert.DeserializeObject(output);
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		public async Task<Object> SearchForPersonAsync(String id, Int32 maxHits, CancellationToken cancellationToken) {
			String searchBody = @"{
 ""query"": {
  ""multi_match"": {
   ""query"": """ + id + @""",
   ""fields"": [
	""Vrdeltagerperson.navne.navn""
   ]
  }
 }
}
";

			HttpClient client = new HttpClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri($"{this.endpoint}/cvr-permanent/deltager");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			String base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.username}:{this.password}"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "_search");
				request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
				request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String output = await response.Content.ReadAsStringAsync();

				return JsonConvert.DeserializeObject(output);
			}
			catch (Exception ex) {
				throw ex;
			}
		}
	}
}
