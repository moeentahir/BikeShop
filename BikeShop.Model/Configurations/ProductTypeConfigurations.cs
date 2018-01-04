using BikeShop.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.DAL
{
    public class ProductTypeConfigurations: EntityTypeConfiguration<Product>
    {
        public ProductTypeConfigurations()
        {
            Property(p => p.Name).IsRequired();

            HasMany(s => s.Categories)
            .WithMany(c => c.Products)
            .Map(cs =>
            {
                cs.MapLeftKey("ProductId");
                cs.MapRightKey("ProductCategoryId");
                cs.ToTable("Product_ProductCategories");
            });
        }
    }
}
