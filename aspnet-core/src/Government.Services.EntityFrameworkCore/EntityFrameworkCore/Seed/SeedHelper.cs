using System;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Uow;
using Abp.MultiTenancy;
using Government.Services.EntityFrameworkCore.Seed.Host;
using Government.Services.EntityFrameworkCore.Seed.Tenants;

namespace Government.Services.EntityFrameworkCore.Seed
{
    public static class SeedHelper
    {
        public static void SeedHostDb(IIocResolver iocResolver)
        {
            WithDbContext<ServicesDbContext>(iocResolver, SeedHostDb);
        }

        public static void SeedHostDb(ServicesDbContext context)
        {
            context.SuppressAutoSetTenantId = true;

            // Host seed
            new InitialHostDbBuilder(context).Create();

            // Default tenant seed (in host database).
            var tenantId = MultiTenancyConsts.DefaultTenantId;
            new DefaultTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, tenantId).Create();
            new AdministrativeFormalityBuilder(context, tenantId).Create();
        }

        private static void WithDbContext<TDbContext>(IIocResolver iocResolver, Action<TDbContext> contextAction)
            where TDbContext : DbContext
        {
            using (var uowManager = iocResolver.ResolveAsDisposable<IUnitOfWorkManager>())
            {
                using (var uow = uowManager.Object.Begin(TransactionScopeOption.Suppress))
                {
                    var context = uowManager.Object.Current.GetDbContext<TDbContext>(MultiTenancySides.Host);

                    contextAction(context);

                    uow.Complete();
                }
            }
        }
    }
}

