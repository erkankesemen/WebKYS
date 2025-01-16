using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class AracBilgi
    {
     
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public int MusteriId { get; set; }
        public int IsEmriNo { get; set; }     
        public string IlgiliKisi { get; set; }
        public string IlgiliKisiTel { get; set; }
        public string SaseNumarasi { get; set; }
        public Nullable<DateTime> AtolyeGirisTarihi { get; set; }
        public string AracMarkasi { get; set; }
        public string Versiyon { get; set; }
        public string Varyant { get; set; }
        public string Tipi { get; set; }
        public string TicariAdi { get; set; }
        public int ModelYili { get; set; }
        public Nullable<DateTime> ProjeTarihi { get; set; }
        public string YapilanTadilat { get; set; }
        public string AracDosemeBilgileri { get; set; }
        public bool? TeklifDurumu { get; set; }
        public bool? SiparisDurumu { get; set; }
        public Nullable<DateTime> KayitTarihi { get; set; }
        public Nullable<DateTime> SiparisTarihi { get; set; }
        public string Fiyat { get; set; }
        public string TeslimYeri { get; set; }
        public Nullable<DateTime> TeslimTarihi { get; set; }
        public string OdemeSekli { get; set; }
        public string MusteriOzelIstekleri { get; set; }
        public string TipOnayNo { get; set; }

        public int KayitAcanId { get; set; }   


        public virtual Firma Firma { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Personel Personel { get; set; }
        public ICollection<Fotograf> Fotograflar { get; set; }
        public ICollection<AracForm> AracFormlari { get; set; }


    }
}
