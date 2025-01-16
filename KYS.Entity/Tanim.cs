using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Tanim
    {
        
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public string Turu { get; set; }
        public string Tanimi { get; set; }
        public string Aciklama { get; set; }
        public string KisaTanimi { get; set; }

        public virtual Firma Firma { get; set; }
    }
}