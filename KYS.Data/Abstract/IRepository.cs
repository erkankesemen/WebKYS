using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Data.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int Id);
        List<T> GetAll();
        void Create(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);

    }
}