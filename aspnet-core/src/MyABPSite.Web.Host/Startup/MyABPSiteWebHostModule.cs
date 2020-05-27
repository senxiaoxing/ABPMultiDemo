using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPSite.Configuration;

namespace MyABPSite.Web.Host.Startup
{
    [DependsOn(
       typeof(MyABPSiteWebCoreModule))]
    public class MyABPSiteWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyABPSiteWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPSiteWebHostModule).GetAssembly());
        }
    }
}
