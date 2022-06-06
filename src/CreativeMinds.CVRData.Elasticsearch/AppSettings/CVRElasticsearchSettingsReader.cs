using System;

namespace CreativeMinds.CVRData.Elasticsearch.AppSettings {

	public class CVRElasticsearchSettingsReader : ICVRElasticsearchSettings {
		public String Username { get; set; }
		public String Password { get; set; }
		public String Endpoint { get; set; }
	}
}
