using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Business.Abstract;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Business.Concrete
{
    public class LoginBilgiManager : ILoginService
    {
        private readonly IUnitOfWork _unitofwork;
        public LoginBilgiManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public void Add(Personel entity)
        {
            _unitofwork.Personel.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Personel entity)
        {
            _unitofwork.Personel.Delete(entity);
            _unitofwork.Save();
        }

        public List<Personel> GetAll()
        {
              return _unitofwork.Personel.GetAll().ToList();
        }

      

        public List<Personel> GetByFirmaKodu(int firmaKodu)
        {
               return _unitofwork.Personel.GetAll()
                .Where(p => p.FirmaKodu == firmaKodu)
                .ToList();
        }

        public Personel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entity)
        {
            _unitofwork.Personel.Update(entity);
            _unitofwork.Save();
        }
    }
}