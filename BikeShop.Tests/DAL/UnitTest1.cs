using System;
using System.Linq;
using BikeShop.DAL;
using BikeShop.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace BikeShop.Tests.DAL
{
    [TestClass]
    public class UnitTest1
    {

        BikeShopDb db;
        [TestInitialize]
        public void Initialize()
        {
            db = new BikeShopDb();

        }

        [TestMethod]
        public void TestMethod1()
        {
            var subCat = db.ProductSubCategories.First();

            Console.WriteLine(subCat.Products.Count());
            var product = new Product
            {
                Name = "Test",
                SubCategory = subCat

            };

            Console.WriteLine(subCat.Products.Count());

            db.Products.Add(product);
            Console.WriteLine(subCat.Products.Count());
            db.SaveChanges();
            Console.WriteLine(subCat.Products.Count());

            Console.WriteLine(db.ProductSubCategories.First().Products.Count());

            Assert.Inconclusive("Check the ourput");
        }
    }
}
