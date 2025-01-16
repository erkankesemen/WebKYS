using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriAdresi { get; set; }
        public string Tel { get; set; }
        public string CepTel { get; set; }
        public int FirmaId { get; set; }



        public virtual ICollection<AracBilgi> Araclar { get; set; }




        public virtual Firma Firma { get; set; }
    }
}