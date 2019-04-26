using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Fanuc.Webmanagement.Configuration.Dto;

namespace Fanuc.Webmanagement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebmanagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
