using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class CihazKalibrasyon
    {
        public int Id { get; set; }
        public int CihazId { get; set; }
        public string KalibrasyonPeriyodu { get; set; }
        public Nullable<DateTime> KalibrasyonTarihi { get; set; }
        public Nullable<DateTime> GelecekKalibrasyonTarihi { get; set; }
        public string KalibrasyonSonucu { get; set; }
        public string KalibrasyonYapildiğiYer { get; set; }
        public int KaliteSorumlusuId { get; set; }
        public bool Hatirlatma { get; set; }
        public int FirmaId { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual Cihaz Cihaz { get; set; }


        public virtual Personel Personel { get; set; }
    }
}