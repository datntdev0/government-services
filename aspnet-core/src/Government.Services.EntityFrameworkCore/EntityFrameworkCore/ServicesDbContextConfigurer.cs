using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Government.Services.EntityFrameworkCore
{
    public static class ServicesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ServicesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ServicesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

