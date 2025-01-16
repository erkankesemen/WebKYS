using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Departman
    {
        public int DepartmanID { get; set; }
        public string DepartmanAdi { get; set; }
        public string Aciklama { get; set; }
        public int FirmaId { get; set; }
        public Nullable<int> YoneticiId { get; set; }
        public bool DepartmanDurumu { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual Personel Yonetici { get; set; }

        // Bir departmanın birden fazla yöneticisi olabilir
        public virtual ICollection<DepartmanYonetici> Yoneticiler { get; set; }

        // Diğer ilişkiler
        public virtual ICollection<Personel> Personeller { get; set; }
    }
}