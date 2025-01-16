using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class Ayar
    {
        public int Id { get; set; }
        public int? FirmaId { get; set; }
        public string? FirmaAdi { get; set; }
        public string? AyarAdi { get; set; }
        public string? AyarSet { get; set; }
        public string? Aciklama { get; set; }
        public bool? TamamlanmaDurumu { get; set; }
    }
}