using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationProject.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
