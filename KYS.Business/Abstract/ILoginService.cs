using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Entity;

namespace KYS.Business.Abstract
{
    public interface ILoginService
    {
        void Add(Personel entity);

     
        void Update(Personel entity);

 
        void Delete(Personel entity);

  
        List<Personel> GetByFirmaKodu(int firmaKodu);

       
        List<Personel> GetAll();

     
        Personel GetById(int id);    
    }
}