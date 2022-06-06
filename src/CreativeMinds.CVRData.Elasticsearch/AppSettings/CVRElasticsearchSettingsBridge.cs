using Microsoft.Extensions.Options;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.AppSettings {

	public class CVRElasticsearchSettingsBridge : ICVRElasticsearchSettings {
		protected readonly IOptionsSnapshot<CVRElasticsearchSettingsReader> optionsConfig;

		public CVRElasticsearchSettingsBridge(IOptionsSnapshot<CVRElasticsearchSettingsReader> optionsConfig) {
			this.optionsConfig = optionsConfig ?? throw new ArgumentNullException(nameof(optionsConfig));
		}

		public String Username => this.optionsConfig.Value.Username;
		public String Password => this.optionsConfig.Value.Password;
		public String Endpoint => this.optionsConfig.Value.Endpoint;
	}
}
