using System;

namespace CreativeMinds.CVRData.Elasticsearch.AppSettings {

	public interface ICVRElasticsearchSettings {
		String Username { get; }
		String Password { get; }
		String Endpoint { get; }
	}
}
