using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Government.Services.EntityFrameworkCore;
using Government.Services.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Government.Services.Web.Tests
{
    [DependsOn(
        typeof(ServicesWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ServicesWebTestModule : AbpModule
    {
        public ServicesWebTestModule(ServicesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServicesWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ServicesWebMvcModule).Assembly);
        }
    }
}
