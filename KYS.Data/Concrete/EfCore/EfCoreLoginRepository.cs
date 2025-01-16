using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;
using KYS.Entity;
using Microsoft.EntityFrameworkCore;

namespace KYS.Data.Concrete.EfCore
{
    public class EfCoreLoginRepository : EfCoreGenericRepository<Personel>, ILoginRepository
    {
        private readonly NetContext _context;

        public EfCoreLoginRepository(NetContext context) : base(context)
        {
            _context = context;
        }

         private NetContext NetContext
        {
            get {return context as NetContext; }
        }
        public async Task<Personel> GetPersonelByUsernameAsync(string username)
        {
            return await _context.Personeller.FirstOrDefaultAsync(p => p.KullaniciAdi == username);
        }

    }
}