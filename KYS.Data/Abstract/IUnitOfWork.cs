using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Data.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        ICartRepository Carts {get;}
        IAracBilgiRepository AracBilgi {get;}
        IMusteriRepository Musteri {get;}
        ILoginRepository Personel {get;}
        void Save();
        Task<int> SaveAsync();
    }
}