using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Government.Services
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class ServicesApplicationContractsModule : AbpModule
    {
        public override void Initialize()
        {
            var thisAssembly = typeof(ServicesApplicationContractsModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

