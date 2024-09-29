using Abp.Configuration;
using System.Collections.Generic;

namespace Government.Services.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return [];
        }
    }
}

