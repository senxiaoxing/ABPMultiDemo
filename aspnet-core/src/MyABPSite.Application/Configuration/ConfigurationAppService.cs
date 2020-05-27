using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyABPSite.Configuration.Dto;

namespace MyABPSite.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyABPSiteAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
