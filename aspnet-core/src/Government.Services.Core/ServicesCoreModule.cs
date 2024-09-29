using Abp.Modules;
using Abp.Reflection.Extensions;
using Government.Services.Core.Shared;

namespace Government.Services
{
    [DependsOn(typeof(ServicesCoreSharedModule))]
    public class ServicesCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            ServicesLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServicesCoreModule).GetAssembly());
        }
    }
}

