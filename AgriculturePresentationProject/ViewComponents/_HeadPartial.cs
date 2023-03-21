using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationProject.ViewComponents
{
	public class _HeadPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
