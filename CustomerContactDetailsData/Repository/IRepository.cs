using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerContactDetailsData.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<bool> Add(TEntity entity);

        Task<bool> Update(TEntity entity);

        bool Remove(TEntity entity);

        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();


    }
}
