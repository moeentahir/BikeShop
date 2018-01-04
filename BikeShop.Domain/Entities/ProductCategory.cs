using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class ProductCategory : GuidEntity
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
