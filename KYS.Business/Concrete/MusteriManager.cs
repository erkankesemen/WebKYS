using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Business.Abstract;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MusteriManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Musteri entity)
        {
            _unitOfWork.Musteri.Create(entity);
            _unitOfWork.Save();
        }


        public void Delete(Musteri entity)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetByFirmaKodu(int firmaKodu)
        {
            throw new NotImplementedException();
        }

        public Musteri GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Musteri entity)
        {
            throw new NotImplementedException();
        }
        List<Musteri> IMusteriService.GetAll()
        {
            return _unitOfWork.Musteri.GetAll();
        }
    }
}