using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class DepartmanYonetici
    {
        public int Id { get; set; }
        public int DepartmanId { get; set; }
        public int YoneticiPersonelId { get; set; }
        public int FirmaId { get; set; }


        public virtual Firma Firma { get; set; }

        public virtual Departman Departman { get; set; }

        public virtual Personel YoneticiPersonel { get; set; }
    }
}