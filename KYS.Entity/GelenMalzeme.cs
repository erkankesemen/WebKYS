using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class GelenMalzeme
    {
               public int Id { get; set; }
       public int FirmaId { get; set; }
       public string MalzemeAdi { get; set; }
       public string FaturaNo { get; set; }
       public string Tedarikci { get; set; }
       public Nullable<DateTime> GelisTarihi { get; set; }
       public string Miktar { get; set; }
       public string Birim { get; set; }
       public string KontrolKriterleri { get; set; }
       public int OnayPersonelId { get; set; }
       public string Aciklama { get; set; }


       public virtual Personel Personel { get; set; }



    }
}