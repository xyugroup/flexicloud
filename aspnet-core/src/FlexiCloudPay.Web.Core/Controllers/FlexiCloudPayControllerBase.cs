using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FlexiCloudPay.Controllers
{
    public abstract class FlexiCloudPayControllerBase: AbpController
    {
        protected FlexiCloudPayControllerBase()
        {
            LocalizationSourceName = FlexiCloudPayConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
