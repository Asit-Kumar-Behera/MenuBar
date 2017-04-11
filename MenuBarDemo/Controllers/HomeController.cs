using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuBarDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Cookies.Add(new HttpCookie("UserType", "Account"));
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