using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.Message = "Calendar";

            return View();
        }
        
        public ActionResult ScalaResources()
        {
            ViewBag.Message = "Scala Resources";

            return View();
        }

        public ActionResult OurDepartment()
        {
            ViewBag.Message = "Our Department";

            return View();
        }

        public ActionResult ProgramsAndEvents()
        {
            ViewBag.Message = "Programs and Events";

            return View();
        }
    }
}
