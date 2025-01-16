using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Firma
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaAdresi { get; set; }
        public int FirmaKodu { get; set; }
        public string FirmaYetkilisi { get; set; }
        public string FirmaTel { get; set; }
        public string CepTel { get; set; }
        public string Email { get; set; }
        public string VergiNumarasi { get; set; }
        public string Adres { get; set; }
        public byte[] Sozlesme { get; set; }
        public string FirmaAdiKisaKodu { get; set; }
        public bool Iso9001 { get; set; }
        public string KYSSorumlusuAdi { get; set; }
        public string KYSSorumlusuSoyAdi { get; set; }
        public string KYSYoneticisiAdi { get; set; }
        public string KYSYoneticisiSoyAdi { get; set; }



        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<Vekalet> Vekaletler { get; set; }
        public virtual ICollection<Departman> Departmanlar { get; set; }
        public virtual ICollection<DepartmanYonetici> DepartmanYoneticileri { get; set; }
        public virtual ICollection<Onay> Onaylar { get; set; }
        public virtual ICollection<AracBilgi> AracBilgileri { get; set; }
        public virtual ICollection<Fotograf> Fotograflar { get; set; }
        public virtual ICollection<Tanim> Tanimlar { get; set; }
        public virtual ICollection<FirmaKontrolMadde> kontrolMaddeleri { get; set; }
        public virtual ICollection<Egitim> Egitimler { get; set; }
        public virtual ICollection<Cihaz> Cihazlar { get; set; }

        public virtual ICollection<GelenMalzeme> GelenMalzemeler { get; set; }
    }
}