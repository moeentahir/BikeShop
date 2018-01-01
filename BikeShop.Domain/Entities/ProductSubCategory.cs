using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain
{
    public class ProductSubCategory : GuidEntity
    {
        public string Name { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
