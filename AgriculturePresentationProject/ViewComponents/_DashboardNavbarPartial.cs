﻿using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationProject.ViewComponents
{
    public class _DashboardNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
