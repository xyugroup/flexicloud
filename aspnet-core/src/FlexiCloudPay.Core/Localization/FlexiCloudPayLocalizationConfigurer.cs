using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FlexiCloudPay.Localization
{
    public static class FlexiCloudPayLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FlexiCloudPayConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FlexiCloudPayLocalizationConfigurer).GetAssembly(),
                        "FlexiCloudPay.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
