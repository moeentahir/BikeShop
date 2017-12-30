using BikeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeShop.Controllers
{
    public class HomeController : Controller
    {
        BikeShopDb db;
        public HomeController()
        {
            db = new BikeShopDb();
        }
        public ActionResult Index()
        {

            return View(db.Products);
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