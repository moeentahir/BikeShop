using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class Product : GuidEntity
    {
        public Product()
        {
            Categories = new HashSet<ProductCategory>();
            Description = "Some default value";
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ProductCategory> Categories { get; set; }

        public ProductSubCategory SubCategory { get; set; }

        public IEnumerable<ProductAttributes> Attributes { get; set; }
    }

    public class ProductAttributes : GuidEntity
    {
        public string Color { get; set; }

        public int Size { get; set; }
    }

    public class MoeenAttribute : ValidationAttribute
    {

    }
}
