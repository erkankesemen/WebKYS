using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class FirmaKontrolMadde
    {
        
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public string FormAdi { get; set; }
        public string KontrolMaddesi { get; set; }
        public bool? Kabul { get; set; }
        public bool? Ret { get; set; }
        public string IslemiYapanUsta { get; set; }


        public virtual Firma Firma { get; set; }
    }
}