using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewsComponents.AdminDashboard
{
    public class _DashboardBanner:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
