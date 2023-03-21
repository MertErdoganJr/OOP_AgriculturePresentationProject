using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
