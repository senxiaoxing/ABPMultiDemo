using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyABPSite.Controllers
{
    public abstract class MyABPSiteControllerBase: AbpController
    {
        protected MyABPSiteControllerBase()
        {
            LocalizationSourceName = MyABPSiteConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
