using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationProject.ViewComponents
{
    public class _DashboardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
