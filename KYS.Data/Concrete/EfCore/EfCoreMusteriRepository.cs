using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Data.Concrete.EfCore
{
    public class EfCoreMusteriRepository : EfCoreGenericRepository<Musteri>, IMusteriRepository
    {
        private readonly NetContext _context;
        public EfCoreMusteriRepository(NetContext context) : base(context)
        {
            _context = context;
            
        }
         private NetContext NetContext
        {
            get {return context as NetContext; }
        }
        private List<Musteri> GetAll()
        {
            return NetContext.Musteriler.ToList();
        }
    }
}