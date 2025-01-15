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

        public void Create(TEntity entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entitiy)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entitiy)
        {
            throw new NotImplementedException();
        }
    }
}