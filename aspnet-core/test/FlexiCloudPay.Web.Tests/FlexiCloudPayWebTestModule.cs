using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCloudPay.EntityFrameworkCore;
using FlexiCloudPay.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FlexiCloudPay.Web.Tests
{
    [DependsOn(
        typeof(FlexiCloudPayWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FlexiCloudPayWebTestModule : AbpModule
    {
        public FlexiCloudPayWebTestModule(FlexiCloudPayEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlexiCloudPayWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FlexiCloudPayWebMvcModule).Assembly);
        }
    }
}