using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCloudPay.Configuration;

namespace FlexiCloudPay.Web.Host.Startup
{
    [DependsOn(
       typeof(FlexiCloudPayWebCoreModule))]
    public class FlexiCloudPayWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FlexiCloudPayWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlexiCloudPayWebHostModule).GetAssembly());
        }
    }
}
