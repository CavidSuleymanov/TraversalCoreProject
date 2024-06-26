using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TraversalCoreProject.ViewsComponents.Default
{
    public class _SliderPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {


            return View();
        }
    }
}
