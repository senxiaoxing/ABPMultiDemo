using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyABPSite.Authorization.Roles;
using MyABPSite.Authorization.Users;
using MyABPSite.MultiTenancy;
using Abp.Localization;

namespace MyABPSite.EntityFrameworkCore
{
    public class MyABPSiteDbContext : AbpZeroDbContext<Tenant, Role, User, MyABPSiteDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyABPSiteDbContext(DbContextOptions<MyABPSiteDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
