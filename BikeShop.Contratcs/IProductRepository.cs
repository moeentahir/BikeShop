using BikeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Contratcs
{
    interface IProductRepository : IRepository<Product, Guid>
    {
        IEnumerable<Product> GetProductsOnSale();

    }
}
