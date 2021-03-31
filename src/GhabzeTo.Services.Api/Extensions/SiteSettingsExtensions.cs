using GhabzeTo.Domain.Core.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using GhabzeTo.Common.GuardToolkit;

namespace GhabzeTo.Services.Api.Extensions
{
    public static class SiteSettingsExtensions
    {
        public static SiteSettings GetSiteSettings(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            var siteSettingsOptions = provider.GetService<IOptionsSnapshot<SiteSettings>>();
            siteSettingsOptions.CheckArgumentIsNull(nameof(siteSettingsOptions));
            var siteSettings = siteSettingsOptions.Value;
            siteSettings.CheckArgumentIsNull(nameof(siteSettings));
            return siteSettings;
        }
    }
}
