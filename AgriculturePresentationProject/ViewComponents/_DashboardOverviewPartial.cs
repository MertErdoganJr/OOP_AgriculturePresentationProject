using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AgriculturePresentationProject.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            DateTime dt  = DateTime.Now;
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x=>x.Date.Month == dt.Month).Count();

            ViewBag.announcementTrue = c.Announcements.Where(x=>x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x=>x.Status == false).Count();

            ViewBag.urunPazarlama = c.Teams.Where(x => x.Title == "Tarım Uzmanı").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunSütUretici = c.Teams.Where(x => x.Title == "Süt ürünleri üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunBakımUzmanı = c.Teams.Where(x => x.Title == "Bakım Uzmanı").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunTarımUzmanı = c.Teams.Where(x => x.Title == "Tarım Uzmanı").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
