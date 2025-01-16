using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Fotograf
    {
        public int Id { get; set; }
        public string GorselLinki { get; set; }
        public int AracBilgiId { get; set; }
        public int FirmaId { get; set; }
        public string DosyaAdi { get; set; }


        public virtual AracBilgi AracBilgi { get; set; }

        public virtual Firma Firma { get; set; }
    }
}