using Abp.MultiTenancy;
using FlexiCloudPay.Authorization.Users;

namespace FlexiCloudPay.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
