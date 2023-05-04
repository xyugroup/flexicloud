using System.Threading.Tasks;
using Abp.Application.Services;
using FlexiCloudPay.Sessions.Dto;

namespace FlexiCloudPay.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
