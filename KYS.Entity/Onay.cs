using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Onay
    {
        public int OnayId { get; set; }
        public int FirmaId { get; set; }
        public int DokumanId { get; set; }
        public int OnaylayanId { get; set; }
        public string OnayDurumu { get; set; } // "Bekliyor", "Onaylandı", "Reddedildi"
        public Nullable<DateTime> OnayaGelenTarih { get; set; }
        public Nullable<DateTime> OnayTarihi { get; set; }
        public string Aciklama { get; set; }

        // Navigation Properties
        public virtual Firma Firma { get; set; }
        public virtual Dokuman Dokuman { get; set; }
        public virtual DepartmanYonetici Onaylayan { get; set; }
    }
}