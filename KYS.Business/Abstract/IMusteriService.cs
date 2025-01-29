using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Entity;

namespace KYS.Business.Abstract
{
    public interface IMusteriService
    {
         void Add(Musteri entity);

     
        void Update(Musteri entity);

 
        void Delete(Musteri entity);

  
        List<Musteri> GetByFirmaKodu(int firmaKodu);

       
        List<Musteri> GetAll();

     
        Musteri GetById(int id);    
    }
}