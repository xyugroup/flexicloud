using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using FlexiCloudPay.Authorization.Users;
using FlexiCloudPay.Editions;

namespace FlexiCloudPay.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
