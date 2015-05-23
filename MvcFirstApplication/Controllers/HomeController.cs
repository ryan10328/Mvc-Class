using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}