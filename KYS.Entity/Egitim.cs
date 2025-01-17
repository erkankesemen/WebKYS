using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Egitim
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int FirmaId { get; set; }
        public string? EgitimVeren { get; set; }
        public string? Konusu { get; set; }
        public Nullable<DateTime> EgitimTarihi { get; set; }
        public string? Saat { get; set; }

        public virtual Personel Personel { get; set; }

        public virtual Firma Firma { get; set; }
    }
}