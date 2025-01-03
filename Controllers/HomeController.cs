using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrameworkWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.WriteLine("Hello from Index action method");
            Trace.WriteLine("More Tracing");
            return View();
        }

        public ActionResult About()
        {
            Trace.WriteLine("Hello from About action method");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Trace.WriteLine("Hello from Contact action method");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}