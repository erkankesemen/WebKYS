using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KYS.WebUI.Identity
{
    public class User : IdentityUser
    {
        public string FirmaKodu { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        
    }
}