using BikeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeShop.Models
{
    public class CreateProductVM
    {

        public Product Product { get; set; }

        public IEnumerable<SelectListItem> ProductCategories { get; set; }
    }
}