using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Vekalet
    {
        public int VekaletID { get; set; }
        public int VekaletiVerenPersonelId { get; set; }
        public int VekaletiAlanPersonelId { get; set; }
        public int FirmaId { get; set; }
        public Nullable<DateTime> BaslangicTarihi { get; set; }
        public Nullable<DateTime> BitisTarihi { get; set; }
        public bool vekalet { get; set; }
        public string Aciklama { get; set; }



        public virtual Firma Firma { get; set; }


        public virtual Personel VekaletiVerenPersonel { get; set; }


        public virtual Personel VekaletiAlanPersonel { get; set; }
    }
}