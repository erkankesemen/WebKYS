using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Dokuman
    {
        public int Id { get; set; }
        public string Kategori { get; set; }
        public string TaslakAdi { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaKisaAdi { get; set; }
        public int FirmaKodu { get; set; }
        public int FirmaId { get; set; }
        public string DokumanAdi { get; set; }
        public string DokumanNo { get; set; }
        public string RevizyonNo { get; set; }
        public Nullable<DateTime> YururlulukTarihi { get; set; }
        public Nullable<DateTime> RevizyonTarihi { get; set; }
        public string DosyaLinki { get; set; }
        public string Hazirlayan { get; set; }
        public string YururlulukOnayi { get; set; }
        public string YururlulukOnayDurumu { get; set; }
        public bool Durumu { get; set; }
        public byte[] Dosya { get; set; }
        public string DosyaAdi { get; set; }
        public string RetSebebi { get; set; }
        public string YapilanDegisiklikler { get; set; }

        public virtual ICollection<Onay> DokumanOnaylar { get; set; }
    }
}