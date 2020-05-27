using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyABPSite.Web.Views
{
    public abstract class MyABPSiteViewComponent : AbpViewComponent
    {
        protected MyABPSiteViewComponent()
        {
            LocalizationSourceName = MyABPSiteConsts.LocalizationSourceName;
        }
    }
}
