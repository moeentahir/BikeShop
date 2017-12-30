namespace BikeShop.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BikeShop.Model.BikeShopDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BikeShop.Model.BikeShopDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(p => p.Name, new Product
            {
                Name = "Cervelo R3",
                Category = new ProductCategory
                {
                    Name = "Bikes"
                },
                SubCategory = new ProductSubCategory
                {

                    Name = "Road bikes"
                }

            });
        }
    }
}
