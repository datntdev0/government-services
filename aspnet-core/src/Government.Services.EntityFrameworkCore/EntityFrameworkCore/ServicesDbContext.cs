using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Government.Services.Authorization.Roles;
using Government.Services.Authorization.Users;
using Government.Services.MultiTenancy;

namespace Government.Services.EntityFrameworkCore
{
    public class ServicesDbContext : AbpZeroDbContext<Tenant, Role, User, ServicesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ServicesDbContext(DbContextOptions<ServicesDbContext> options)
            : base(options)
        {
        }
    }
}

