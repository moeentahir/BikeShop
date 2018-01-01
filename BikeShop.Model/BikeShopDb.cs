using BikeShop.Domain;
using BikeShop.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.DAL
{
    public class BikeShopDb : IdentityDbContext<ApplicationUser>
    {
        public BikeShopDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BikeShopDb Create()
        {
            return new BikeShopDb();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(P => P.Name).IsConcurrencyToken();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductAttributes> ProductAttributes { get; set; }

    }
}
