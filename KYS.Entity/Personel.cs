using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Personel
    {
        [Key] 
        public int PersonelID { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public int FirmaId { get; set; }
        public int FirmaKodu { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? Unvan { get; set; }
        public bool Durum { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? DepartmanID { get; set; }
        public int? UstYoneticiID { get; set; }

        public bool OnayYetkisi { get; set; }
        public string? OnayGrubu { get; set; }
        public string? KullaniciRolu { get; set; }



        public virtual Departman Departman { get; set; }

        public virtual Personel UstYonetici { get; set; }

        public virtual Firma Firma { get; set; }    

        
 
        public virtual ICollection<Departman> Departmanlar { get; set; }      
        public virtual ICollection<DepartmanYonetici> DepartmanYoneticileri { get; set; }
        public virtual ICollection<Vekalet> VekaletlerVeren { get; set; }
        public virtual ICollection<Vekalet> VekaletlerAlan { get; set; }   
        public virtual ICollection<AracBilgi> AracBilgileri { get; set; }    
        public virtual ICollection<Egitim> Egitimler { get; set; }
        public virtual ICollection<CihazKalibrasyon> CihazKalibrasyonlari { get; set; }
        public virtual ICollection<GelenMalzeme> GelenMalzemeler { get; set; }

    }
}