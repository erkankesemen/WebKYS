using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.WebUI.Models
{
    public class LoginModel
    {
        [Required]
        public int FirmaKodu { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}