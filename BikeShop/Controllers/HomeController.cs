using BikeShop.DAL;
using BikeShop.Domain;
using BikeShop.Models;
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

        [HttpGet]
        public ActionResult CreateProduct()
        {
            var model = new CreateProductVM
            {
                Product = new Product { Id = Guid.NewGuid() },
                ProductCategories = db.ProductCategories.ToList().Select(p => new SelectListItem { Text = p.Name, Value = p.Id.ToString() })
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateProduct(CreateProductVM product)
        {
            if (ModelState.IsValid)
            {

                db.Products.Add(product.Product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }



    }
}