using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Contratcs
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity GetById(TKey id);
        IEnumerable<TEntity> GetList();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
