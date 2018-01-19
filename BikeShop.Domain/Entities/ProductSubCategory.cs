using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class ProductSubCategory : GuidEntity
    {
        public string Name { get; set; }

        [InverseProperty("SubCategory")]
        public virtual IEnumerable<Product> Products { get; set; }

        public ProductSubCategory()
        {
            Products = new HashSet<Product>();
        }
    }
}
