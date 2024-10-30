using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;

namespace Government.Services.EntityFrameworkCore
{
    [DependsOn(
        typeof(ServicesCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ServicesEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ServicesDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ServicesDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ServicesDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServicesEntityFrameworkModule).GetAssembly());
        }
    }
}

