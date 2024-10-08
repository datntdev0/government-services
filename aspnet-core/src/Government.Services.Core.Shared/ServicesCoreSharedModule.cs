using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Government.Services.Authorization.Roles;
using Government.Services.Authorization.Users;
using Government.Services.Configuration;
using Government.Services.MultiTenancy;

namespace Government.Services.Core.Shared
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ServicesCoreSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ServicesConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
            SimpleStringCipher.DefaultPassPhrase = ServicesConsts.DefaultPassPhrase;

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = ServicesConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServicesCoreSharedModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}

