using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Model
{
    public class Product : GuidEntity
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ProductCategory Category { get; set; }

        public ProductSubCategory SubCategory { get; set; }

    }
}
