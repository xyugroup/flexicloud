using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCloudPay.Authorization;

namespace FlexiCloudPay
{
    [DependsOn(
        typeof(FlexiCloudPayCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FlexiCloudPayApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FlexiCloudPayAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FlexiCloudPayApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
