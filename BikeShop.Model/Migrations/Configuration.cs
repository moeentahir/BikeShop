namespace BikeShop.DAL.Migrations
{
    using BikeShop.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BikeShopDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BikeShopDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            
            context.Products.AddOrUpdate(p => p.Name, new Product
            {
                Name = "Cervelo R3",
                Categories = new[]{ new ProductCategory
                {
                    Name = "Bikes"
                } },
                SubCategory = new ProductSubCategory
                {

                    Name = "Road bikes"
                },

                Attributes = new List<ProductAttributes> { new ProductAttributes { Color = "Blue" } }

            });
        }

    }
}
