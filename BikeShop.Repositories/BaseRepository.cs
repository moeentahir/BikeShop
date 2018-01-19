using BikeShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Repositories
{
    public class BaseRepository<TEntity>
    {
        BikeShopDb db;
        public BaseRepository()
        {
            db = new BikeShopDb();
        }


    }
}
