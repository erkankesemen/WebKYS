using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class AracForm
    {
        public int AracFormID { get; set; }
        public int AracId { get; set; }
        public string SiparisBilgiFormu { get; set; }
        public string UruneBagliSartlariGozdenGecirmeFormu { get; set; }
        public string IsEmriFormu { get; set; }
        public string IsEmriveUrunIzlemeFormu { get; set; }
        public string KontrolFormuLinki { get; set; }
        public string RuhsatLinki { get; set; }
        public string ProjeDosyasiLinki { get; set; }
        public string FaturasiLinki { get; set; }
        public string FotografDurumu { get; set; }



        public virtual AracBilgi AracBilgi { get; set; }
    }
}