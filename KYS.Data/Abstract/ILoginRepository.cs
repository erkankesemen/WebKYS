using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Entity;

namespace KYS.Data.Abstract
{
    public interface ILoginRepository : IRepository<Personel>
    {
         Task<Personel> GetPersonelByUsernameAsync(string username);
    }
    
}