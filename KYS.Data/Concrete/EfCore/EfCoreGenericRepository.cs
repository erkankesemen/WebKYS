using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KYS.Data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
    where TEntity : class
    {
        protected readonly DbContext context;
        public EfCoreGenericRepository(DbContext ctx)
        {
            context = ctx;
        }

      public void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public virtual void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        List<TEntity> IRepository<TEntity>.GetAll()
        {
            return context.Set<TEntity>().ToList(); 
        }

        TEntity IRepository<TEntity>.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}