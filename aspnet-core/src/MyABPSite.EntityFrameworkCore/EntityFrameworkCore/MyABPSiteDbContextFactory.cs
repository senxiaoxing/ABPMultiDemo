using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyABPSite.Configuration;
using MyABPSite.Web;

namespace MyABPSite.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyABPSiteDbContextFactory : IDesignTimeDbContextFactory<MyABPSiteDbContext>
    {
        public MyABPSiteDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyABPSiteDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyABPSiteDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyABPSiteConsts.ConnectionStringName));

            return new MyABPSiteDbContext(builder.Options);
        }
    }
}
