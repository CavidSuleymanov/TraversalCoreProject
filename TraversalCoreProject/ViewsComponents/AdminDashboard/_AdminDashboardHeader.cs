using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewsComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
