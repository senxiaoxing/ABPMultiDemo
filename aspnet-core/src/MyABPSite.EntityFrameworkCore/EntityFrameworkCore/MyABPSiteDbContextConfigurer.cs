using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyABPSite.EntityFrameworkCore
{
    public static class MyABPSiteDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPSiteDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(
                connectionString, 
                options => options.SetPostgresVersion(new Version(9, 6)));
        }

        public static void Configure(DbContextOptionsBuilder<MyABPSiteDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
    }
}
