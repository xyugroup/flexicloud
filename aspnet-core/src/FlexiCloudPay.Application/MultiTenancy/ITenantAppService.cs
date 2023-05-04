using Abp.Application.Services;
using FlexiCloudPay.MultiTenancy.Dto;

namespace FlexiCloudPay.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

