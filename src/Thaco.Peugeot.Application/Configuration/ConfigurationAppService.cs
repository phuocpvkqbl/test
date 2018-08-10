using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Thaco.Peugeot.Configuration.Dto;

namespace Thaco.Peugeot.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PeugeotAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
