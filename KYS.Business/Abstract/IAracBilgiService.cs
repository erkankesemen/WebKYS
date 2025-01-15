using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using KYS.Business.Concrete;
using KYS.Entity;

namespace KYS.Business.Abstract
{
    public interface IAracBilgiService
    {
  
        void Add(AracBilgi entity);

     
        void Update(AracBilgi entity);

 
        void Delete(AracBilgi entity);

  
        List<AracBilgi> GetByFirmaKodu(string firmaKodu);

       
        List<AracBilgi> GetAll();

     
        AracBilgi GetById(int id);  
    }
}