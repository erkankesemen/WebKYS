using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Entity;
using Microsoft.EntityFrameworkCore;

namespace KYS.Data.Concrete
{
    public class NetContext : DbContext
    {
        public NetContext(DbContextOptions<NetContext> options) : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Dokuman> Dokumanlar { get; set; }
        public DbSet<FirmaKontrolMadde> FirmaKontrolMaddeleri { get; set; }
        public DbSet<Ayar> Ayarlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<DepartmanYonetici> DepartmanYoneticileri { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Vekalet> Vekaletler { get; set; }
        public DbSet<Fotograf> Fotograflar { get; set; }
        public DbSet<AracBilgi> AracBilgileri { get; set; }
        public DbSet<AppVersion> AppVersions { get; set; }
        public DbSet<Onay> Onaylar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<AracForm> AracForms { get; set; }
        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<Cihaz> Cihazlar { get; set; }
        public DbSet<CihazKalibrasyon> CihazKalibrasyonLari { get; set; }
        public DbSet<GelenMalzeme> GelenMalzemeler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>()
                .HasKey(p => p.PersonelID); // Birincil anahtar
            modelBuilder.Entity<Personel>()
                .Property(p => p.PersonelID)
                .HasColumnName("PersonelID"); // Sütun adı

    

            modelBuilder.Entity<DepartmanYonetici>()
                .HasOne(c => c.Departman)
                .WithMany(d => d.Yoneticiler)
                .HasForeignKey(c => c.DepartmanId)
             .OnDelete(DeleteBehavior.Restrict);

            // DepartmanYonetici - YoneticiPersonel ilişki
            modelBuilder.Entity<DepartmanYonetici>()
               .HasOne(c => c.YoneticiPersonel)
               .WithMany(p => p.DepartmanYoneticileri)
               .HasForeignKey(c => c.YoneticiPersonelId)
           .OnDelete(DeleteBehavior.Restrict);

            // DepartmanYonetici - Firma ilişki
            modelBuilder.Entity<DepartmanYonetici>()
               .HasOne(c => c.Firma)
               .WithMany(f => f.DepartmanYoneticileri)
               .HasForeignKey(c => c.FirmaId)
               .OnDelete(DeleteBehavior.Restrict);

            // Personel - Departman ilişki
            modelBuilder.Entity<Personel>()
               .HasOne(p => p.Departman)
               .WithMany(d => d.Personeller)
               .HasForeignKey(p => p.DepartmanID)
               .OnDelete(DeleteBehavior.Restrict);

            // Personel - Firma ilişki
            modelBuilder.Entity<Personel>()
               .HasOne(p => p.Firma)
               .WithMany(f => f.Personeller)
               .HasForeignKey(p => p.FirmaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Fotograf - Firma ilişki
            modelBuilder.Entity<Fotograf>()
               .HasOne(d => d.Firma)
               .WithMany(f => f.Fotograflar)
               .HasForeignKey(d => d.FirmaId)
              .OnDelete(DeleteBehavior.Restrict);

            // Departman - Firma ilişki
            modelBuilder.Entity<Departman>()
               .HasOne(d => d.Firma)
               .WithMany(f => f.Departmanlar)
               .HasForeignKey(d => d.FirmaId)
            .OnDelete(DeleteBehavior.Restrict);

            // Vekalet - Firma ilişki


            modelBuilder.Entity<Vekalet>()
               .HasOne(v => v.VekaletiVerenPersonel)
               .WithMany(p => p.VekaletlerVeren)
               .HasForeignKey(v => v.VekaletiVerenPersonelId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vekalet>()
               .HasOne(v => v.VekaletiAlanPersonel)
               .WithMany(p => p.VekaletlerAlan)
               .HasForeignKey(v => v.VekaletiAlanPersonelId)
               .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Departman>()
               .HasOne(d => d.Yonetici)
               .WithMany()
               .HasForeignKey(d => d.YoneticiId)
               .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<FirmaKontrolMadde>()
               .HasOne(c => c.Firma)
               .WithMany(c => c.kontrolMaddeleri)
               .HasForeignKey(c => c.FirmaId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Onay>()
               .HasOne(c => c.Firma)
               .WithMany(c => c.Onaylar)
               .HasForeignKey(c => c.FirmaId)
           .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.Entity<AracForm>()
                .HasOne(c => c.AracBilgi)
                .WithMany(c => c.AracFormlari)
                .HasForeignKey(c => c.AracId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Egitim>()
                .HasOne(c => c.Firma)
                .WithMany(c => c.Egitimler)
                .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Egitim>()
                .HasOne(c => c.Personel)
                .WithMany(c => c.Egitimler)
                .HasForeignKey(c => c.PersonelId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<CihazKalibrasyon>()
                .HasOne(c => c.Cihaz)
                .WithMany(c => c.CihazKalibrasyonlari)
                .HasForeignKey(c => c.CihazId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cihaz>()
                .HasOne(c => c.Firma)
                .WithMany(c => c.Cihazlar)
                .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CihazKalibrasyon>()
                .HasOne(c => c.Personel)
                .WithMany(c => c.CihazKalibrasyonlari)
                .HasForeignKey(c => c.KaliteSorumlusuId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<AracBilgi>()
                .HasOne(c=>c.Personel)
                .WithMany(c=>c.AracBilgileri)
                .HasForeignKey(c=>c.KayitAcanId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AracBilgi>()
                .HasOne(c => c.Firma)
                .WithMany(c => c.AracBilgileri)
                .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.NoAction); // ON DELETE CASCADE yerine NO ACTION

            modelBuilder.Entity<AracBilgi>()
                .HasOne(c => c.Musteri)
                .WithMany(m => m.Araclar)
                .HasForeignKey(c => c.MusteriId)
                .OnDelete(DeleteBehavior.NoAction); // ON DELETE CASCADE yerine NO ACTION


            base.OnModelCreating(modelBuilder);
        }
    }
}
