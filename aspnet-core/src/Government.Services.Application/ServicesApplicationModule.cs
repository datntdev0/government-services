using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Government.Services
{
    [DependsOn(
        typeof(ServicesApplicationContractsModule),
        typeof(ServicesCoreModule))]
    public class ServicesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ServicesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ServicesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
        }
    }
}

