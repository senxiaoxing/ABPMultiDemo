using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPSite.Authorization;

namespace MyABPSite
{
    [DependsOn(
        typeof(MyABPSiteCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyABPSiteApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyABPSiteAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyABPSiteApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
