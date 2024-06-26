using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewsComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
