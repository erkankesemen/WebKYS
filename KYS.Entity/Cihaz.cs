using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Cihaz
    {
        public int Id { get; set; }
        public string? CihazKodu { get; set; }
        public string? CihazAdi { get; set; }
        public string? Markasi { get; set; }
        public string? Modeli { get; set; }
        public string? SeriNo { get; set; }
        public string? Hassasiyet { get; set; }
        public string? SatinAlinanFirma { get; set; }

        public Nullable<DateTime> SatinAlmaTarihi { get; set; }
        public int FirmaId { get; set; }
        public string? Not { get; set; }


        public virtual Firma Firma { get; set; }

        public ICollection<CihazKalibrasyon> CihazKalibrasyonlari { get; set; }
    }
}