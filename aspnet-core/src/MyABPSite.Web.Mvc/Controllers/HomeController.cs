using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyABPSite.Controllers;

namespace MyABPSite.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyABPSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
