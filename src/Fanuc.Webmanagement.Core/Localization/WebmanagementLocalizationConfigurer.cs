using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Fanuc.Webmanagement.Localization
{
    public static class WebmanagementLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WebmanagementConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WebmanagementLocalizationConfigurer).GetAssembly(),
                        "Fanuc.Webmanagement.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
