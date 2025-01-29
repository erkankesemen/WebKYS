using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly NetContext _context;
        private EfCoreAracBilgiRepository _aracbilgiRepository;
        private EfCoreCartRepository _cartRepository;
        private EfCoreMusteriRepository _musteriRepository;
        private EfCoreLoginRepository _loginRepository;
        public UnitOfWork(NetContext context)
        {
            _context = context;
        }


        public IAracBilgiRepository AracBilgi
        => _aracbilgiRepository ??= new EfCoreAracBilgiRepository(_context);

        public ILoginRepository Personel
        => _loginRepository ??= new EfCoreLoginRepository(_context);

        public ICartRepository Carts => 
            _cartRepository = _cartRepository ?? new EfCoreCartRepository(_context);

        public IMusteriRepository Musteri => 
            _musteriRepository =_musteriRepository ?? new EfCoreMusteriRepository(_context);   

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