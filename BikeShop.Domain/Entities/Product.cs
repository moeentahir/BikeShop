using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class Product : GuidEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ProductCategory Category { get; set; }

        public ProductSubCategory SubCategory { get; set; }

        public IEnumerable<ProductAttributes> Attributes { get; set; }

        public Product()
        {
            Description = "Some default value";
        }

    }

    public class ProductAttributes : GuidEntity
    {
        public string Color { get; set; }

        public int Size { get; set; }
    }
}
