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
                .OnDelete(DeleteBehavior.Cascade);

            // DepartmanYonetici - YoneticiPersonel ilişki
            modelBuilder.Entity<DepartmanYonetici>()
               .HasOne(c => c.YoneticiPersonel)
               .WithMany(p => p.DepartmanYoneticileri)
               .HasForeignKey(c => c.YoneticiPersonelId)
               .OnDelete(DeleteBehavior.Cascade);

            // DepartmanYonetici - Firma ilişki
            modelBuilder.Entity<DepartmanYonetici>()
               .HasOne(c => c.Firma)
               .WithMany(f => f.DepartmanYoneticileri)
               .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Personel - Departman ilişki
            modelBuilder.Entity<Personel>()
               .HasOne(p => p.Departman)
               .WithMany(d => d.Personeller)
               .HasForeignKey(p => p.DepartmanID)
                .OnDelete(DeleteBehavior.Cascade);

            // Personel - Firma ilişki
            modelBuilder.Entity<Personel>()
               .HasOne(p => p.Firma)
               .WithMany(f => f.Personeller)
               .HasForeignKey(p => p.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Fotograf - Firma ilişki
            modelBuilder.Entity<Fotograf>()
               .HasOne(d => d.Firma)
               .WithMany(f => f.Fotograflar)
               .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Departman - Firma ilişki
            modelBuilder.Entity<Departman>()
               .HasOne(d => d.Firma)
               .WithMany(f => f.Departmanlar)
               .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Vekalet - Firma ilişki
            modelBuilder.Entity<Vekalet>()
               .HasOne(d => d.Firma)
               .WithMany(c => c.Vekaletler)
               .HasForeignKey(a => a.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vekalet>()
               .HasOne(v => v.VekaletiVerenPersonel)
               .WithMany(p => p.VekaletlerVeren)
               .HasForeignKey(v => v.VekaletiVerenPersonelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vekalet>()
               .HasOne(v => v.VekaletiAlanPersonel)
               .WithMany(p => p.VekaletlerAlan)
               .HasForeignKey(v => v.VekaletiAlanPersonelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vekalet>()
               .HasOne(v => v.Firma)
               .WithMany()
               .HasForeignKey(v => v.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Departman>()
               .HasOne(d => d.Yonetici)
               .WithMany()
               .HasForeignKey(d => d.YoneticiId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AracBilgi>()
               .HasOne(c => c.Firma)
               .WithMany(c => c.AracBilgileri)
               .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FirmaKontrolMadde>()
               .HasOne(c => c.Firma)
               .WithMany(c => c.kontrolMaddeleri)
               .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Onay>()
               .HasOne(c => c.Firma)
               .WithMany(c => c.Onaylar)
               .HasForeignKey(c => c.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AracBilgi>()
                .HasOne(a => a.Musteri)
                .WithMany(m => m.Araclar)
                .HasForeignKey(a => a.MusteriId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AracBilgi>()
                .HasOne(c => c.Personel)
                .WithMany(c => c.AracBilgileri)
                .HasForeignKey(c => c.KayitAcanId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AracForm>()
                .HasOne(c => c.AracBilgi)
                .WithMany(c => c.AracFormlari)
                .HasForeignKey(c => c.AracId)
                 .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Egitim>()
                .HasOne(c => c.Firma)
                .WithMany(c => c.Egitimler)
                .HasForeignKey(c => c.FirmaId)
                 .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Egitim>()
                .HasOne(c => c.Personel)
                .WithMany(c => c.Egitimler)
                .HasForeignKey(c => c.PersonelId)
                 .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<CihazKalibrasyon>()
                .HasOne(c => c.Cihaz)
                .WithMany(c => c.CihazKalibrasyonlari)
                .HasForeignKey(c => c.CihazId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cihaz>()
                .HasOne(c => c.Firma)
                .WithMany(c => c.Cihazlar)
                .HasForeignKey(c => c.FirmaId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CihazKalibrasyon>()
                .HasOne(c => c.Personel)
                .WithMany(c => c.CihazKalibrasyonlari)
                .HasForeignKey(c => c.KaliteSorumlusuId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GelenMalzeme>()
            .HasOne(g => g.Personel)  // GelenMalzeme'nin bir Personel ile ilişkisi
            .WithMany()                // Personel'in birden fazla GelenMalzeme'ye sahip olabileceğini belirtir
            .HasForeignKey(g => g.OnayPersonelId);  // GelenMalzeme'deki PersonelID yabancı anahtarı

        modelBuilder.Entity<GelenMalzeme>()
            .HasOne(g => g.Firma)  // GelenMalzeme'nin bir Firma ile ilişkisi
            .WithMany()             // Firma'nın birden fazla GelenMalzeme'ye sahip olabileceğini belirtir
            .HasForeignKey(g => g.FirmaId);  // GelenMalzeme'deki FirmaID yabancı anahtarı


            base.OnModelCreating(modelBuilder);
        }
    }
}
