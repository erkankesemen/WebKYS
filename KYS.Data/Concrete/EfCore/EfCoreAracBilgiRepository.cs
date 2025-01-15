using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Data.Concrete.EfCore
{
    public class EfCoreAracBilgiRepository:
        EfCoreGenericRepository<AracBilgi>, IAracBilgiRepository
        
    {
        public EfCoreAracBilgiRepository(NetContext context) : base (context)
        {
            
        }

        private NetContext NetContext
        {
            get {return context as NetContext; }
        }
        public void Create(AracBilgi entity)
        {
            NetContext.AracBilgileri.Add(entity);
            NetContext.SaveChanges();
        }

        public void Delete(AracBilgi entity)
        {
            NetContext.AracBilgileri.Remove(entity);
            NetContext.SaveChanges();
        }

        public List<AracBilgi> GetAll()
        {
            return NetContext.AracBilgileri.ToList();
        }

        public AracBilgi GetById(int Id)
        {
            return NetContext.AracBilgileri.FirstOrDefault(x => x.Id == Id);
        }

        public void Update(AracBilgi entity)
        {
            NetContext.AracBilgileri.Update(entity);
            NetContext.SaveChanges();
        }
    }
}