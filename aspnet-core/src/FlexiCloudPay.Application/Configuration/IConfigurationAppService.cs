using System.Threading.Tasks;
using FlexiCloudPay.Configuration.Dto;

namespace FlexiCloudPay.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
