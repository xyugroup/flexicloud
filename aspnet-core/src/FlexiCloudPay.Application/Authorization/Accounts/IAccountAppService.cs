using System.Threading.Tasks;
using Abp.Application.Services;
using FlexiCloudPay.Authorization.Accounts.Dto;

namespace FlexiCloudPay.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
