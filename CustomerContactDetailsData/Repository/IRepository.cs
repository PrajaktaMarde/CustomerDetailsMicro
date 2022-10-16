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

        Task<bool> Remove(int id);

        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();


    }
}
