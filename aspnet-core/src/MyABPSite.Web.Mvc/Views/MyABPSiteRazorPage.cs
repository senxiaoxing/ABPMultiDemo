using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyABPSite.Web.Views
{
    public abstract class MyABPSiteRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyABPSiteRazorPage()
        {
            LocalizationSourceName = MyABPSiteConsts.LocalizationSourceName;
        }
    }
}
