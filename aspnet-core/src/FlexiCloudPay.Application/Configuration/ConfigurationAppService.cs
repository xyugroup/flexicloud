using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FlexiCloudPay.Configuration.Dto;

namespace FlexiCloudPay.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FlexiCloudPayAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
