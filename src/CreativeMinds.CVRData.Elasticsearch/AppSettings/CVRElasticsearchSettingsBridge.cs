using Microsoft.Extensions.Options;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.AppSettings {

	public class CVRElasticsearchSettingsBridge : ICVRElasticsearchSettings {
		protected readonly IOptionsMonitor<CVRElasticsearchSettingsReader> optionsConfig;

		public CVRElasticsearchSettingsBridge(IOptionsMonitor<CVRElasticsearchSettingsReader> optionsConfig) {
			this.optionsConfig = optionsConfig ?? throw new ArgumentNullException(nameof(optionsConfig));
		}

		public String Username => this.optionsConfig.CurrentValue.Username;
		public String Password => this.optionsConfig.CurrentValue.Password;
		public String Endpoint => this.optionsConfig.CurrentValue.Endpoint;
	}
}
