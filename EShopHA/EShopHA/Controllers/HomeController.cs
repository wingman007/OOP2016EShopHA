using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShopHA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        
        public ActionResult Cart()
        {
            ViewBag.Message = "Shopping Cart";

            return View();
        }

        public ActionResult Hookas()
        {
            ViewBag.Message = "Hookas";

            return View();
        }
        public ActionResult Alcohols()
        {
            ViewBag.Message = "Alcohols";

            return View();
        }
        [Authorize(Users="admin")]
        public ActionResult Admin()
        {
            ViewBag.Message = "Admin";

            return View();
        }
    }
}