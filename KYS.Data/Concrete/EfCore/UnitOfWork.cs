using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;

namespace KYS.Data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
            private readonly NetContext _context;

        private EfCoreAracBilgiRepository _aracbilgiRepository;
            public UnitOfWork(NetContext context)
            {
                _context = context;
            }


        public IAracBilgiRepository AracBilgi
        => _aracbilgiRepository ??= new EfCoreAracBilgiRepository(_context);



        public void Dispose()
        {
             _context.Dispose();
        }

        public void Save()
        {
             _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }
    }
}