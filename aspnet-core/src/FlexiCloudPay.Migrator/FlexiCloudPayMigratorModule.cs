using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlexiCloudPay.Configuration;
using FlexiCloudPay.EntityFrameworkCore;
using FlexiCloudPay.Migrator.DependencyInjection;

namespace FlexiCloudPay.Migrator
{
    [DependsOn(typeof(FlexiCloudPayEntityFrameworkModule))]
    public class FlexiCloudPayMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FlexiCloudPayMigratorModule(FlexiCloudPayEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FlexiCloudPayMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FlexiCloudPayConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlexiCloudPayMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
