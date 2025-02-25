using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Business.Abstract;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Business.Concrete
{
    
    public class AracBilgiManager : IAracBilgiService
    {
        private readonly IUnitOfWork _unitofwork;
        public AracBilgiManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public void Add(AracBilgi entity)
        {
            if (entity.MusteriId <= 0)
            {
                throw new ArgumentException("Müşteri seçimi yapılmadı!");
            }

            var musteri = _unitofwork.Musteri.GetById(entity.MusteriId);
            if (musteri == null)
            {
                throw new ArgumentException("Seçilen müşteri bulunamadı!");
            }

            entity.MusteriId = musteri.MusteriId;
            entity.KayitTarihi = DateTime.Now;
            
            _unitofwork.AracBilgi.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(AracBilgi entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AracBilgi>> GetAll()
        {
           throw new NotImplementedException();
        }

        public List<AracBilgi> GetByFirmaKodu(string firmaKodu)
        {
            throw new NotImplementedException();
        }

        public AracBilgi GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AracBilgi entity)
        {
            throw new NotImplementedException();
        }

        List<AracBilgi> IAracBilgiService.GetAll()
        {
            return _unitofwork.AracBilgi.GetAll();
        }
    }
}