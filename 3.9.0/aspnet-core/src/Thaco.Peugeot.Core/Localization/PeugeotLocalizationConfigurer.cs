using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Thaco.Peugeot.Localization
{
    public static class PeugeotLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PeugeotConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PeugeotLocalizationConfigurer).GetAssembly(),
                        "Thaco.Peugeot.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
