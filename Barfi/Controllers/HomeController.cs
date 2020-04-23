using Barfi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Barfi.Controllers
{
    public class HomeController : Controller
    {
        IBarData db;
        //Add IOC container.
        public HomeController(IBarData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.getAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "BarFi description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Barfi contact page.";

            return View();
        }

        public ActionResult Meeseeks()
        {
            ViewBag.Message = "Hi I'm Mr. Meeseeks!";

            return View();
        }
    }
}