using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerContactDetailsData.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        internal DbSet<TEntity> dbSet;
        public Repository(DbContext context)
        {
            Context = context;
            dbSet = Context.Set<TEntity>();
          
        }
        public virtual Task<bool> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        

        public virtual async Task<TEntity> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual bool Remove(TEntity entity)
        {
            throw new NotImplementedException();

        }

       
        public virtual Task<bool> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
