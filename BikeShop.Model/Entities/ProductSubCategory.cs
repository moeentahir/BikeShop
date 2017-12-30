using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Model
{
    public class ProductSubCategory : GuidEntity
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
    }
}
