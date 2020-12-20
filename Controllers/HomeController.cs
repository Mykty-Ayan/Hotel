using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Almaty Tyni is the Hotel Management System for Final ASP.NET subject";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Project Creators: Ayan Akkassov, Dias Kozhabay";

            return View();
        }
    }
}