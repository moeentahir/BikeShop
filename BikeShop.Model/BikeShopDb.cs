using BikeShop.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Model
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

        public DbSet<Product> Products { get; set; }

    }
}
