using HealthAssist.Extensions;
using HealthAssist.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthAssist.Controllers
{
    public class HomeController : Controller
    {
        //ILoggingService _logger;
        //public HomeController(ILoggingService logger)
        //{
        //    _logger = logger;
        //}
        public ActionResult Index()
        {
            var person = new Person { FirstName = "Bob", LastName = "John", Age = 32 };
            //return JsonNet(person);
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

        [IsMobile]
        public JsonResult Register()
        {
            return Json("{ Message: Dispaly on Mobile Devices }");
        }


        public ActionResult Register(string name)
        {
            return View();
        }

        private ActionResult JsonNet(object data)
        {
            return new JsonNETResult() { Data = data };
        }
    }
}