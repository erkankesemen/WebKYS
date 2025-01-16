using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Data.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        IAracBilgiRepository AracBilgi {get;}
        ILoginRepository Personel {get;}
        void Save();
        Task<int> SaveAsync();
    }
}