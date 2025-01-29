using KYS.Entity.ViewModels;

namespace KYS.Entity.ViewModels
{
    public class AracBilgiViewModel
    {
        public IEnumerable<AracBilgi> AracBilgileri { get; set; }
        public IEnumerable<Musteri> Musteriler { get; set; }
        public Musteri Musteri { get; set; }
    }
} 