using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ayarlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: true),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AyarAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AyarSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TamamlanmaDurumu = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayarlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dokumanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaslakAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaKisaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaKodu = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    DokumanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DokumanNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevizyonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YururlulukTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevizyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DosyaLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hazirlayan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YururlulukOnayi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YururlulukOnayDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    Dosya = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetSebebi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YapilanDegisiklikler = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaKodu = table.Column<int>(type: "int", nullable: false),
                    FirmaYetkilisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sozlesme = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FirmaAdiKisaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iso9001 = table.Column<bool>(type: "bit", nullable: false),
                    KYSSorumlusuAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KYSSorumlusuSoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KYSYoneticisiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KYSYoneticisiSoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cihazlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Markasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hassasiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatinAlinanFirma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatinAlmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Not = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihazlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cihazlar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FirmaKontrolMaddeleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    FormAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontrolMaddesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kabul = table.Column<bool>(type: "bit", nullable: true),
                    Ret = table.Column<bool>(type: "bit", nullable: true),
                    IslemiYapanUsta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaKontrolMaddeleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirmaKontrolMaddeleri_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriId);
                    table.ForeignKey(
                        name: "FK_Musteriler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tanimlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Turu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tanimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KisaTanimi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanimlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tanimlar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AracBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    IsEmriNo = table.Column<int>(type: "int", nullable: false),
                    IlgiliKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlgiliKisiTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaseNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtolyeGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AracMarkasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Versiyon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varyant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicariAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelYili = table.Column<int>(type: "int", nullable: true),
                    ProjeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YapilanTadilat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracDosemeBilgileri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeklifDurumu = table.Column<bool>(type: "bit", nullable: true),
                    SiparisDurumu = table.Column<bool>(type: "bit", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeslimYeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriOzelIstekleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipOnayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitAcanId = table.Column<int>(type: "int", nullable: true),
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AracBilgileri_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AracBilgileri_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "MusteriId");
                });

            migrationBuilder.CreateTable(
                name: "AracForms",
                columns: table => new
                {
                    AracFormID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    SiparisBilgiFormu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UruneBagliSartlariGozdenGecirmeFormu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmriFormu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmriveUrunIzlemeFormu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontrolFormuLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RuhsatLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeDosyasiLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturasiLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotografDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracForms", x => x.AracFormID);
                    table.ForeignKey(
                        name: "FK_AracForms_AracBilgileri_AracId",
                        column: x => x.AracId,
                        principalTable: "AracBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fotograflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorselLinki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracBilgiId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograflar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotograflar_AracBilgileri_AracBilgiId",
                        column: x => x.AracBilgiId,
                        principalTable: "AracBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotograflar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CihazKalibrasyonLari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazId = table.Column<int>(type: "int", nullable: false),
                    KalibrasyonPeriyodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KalibrasyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GelecekKalibrasyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KalibrasyonSonucu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KalibrasyonYapildiğiYer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KaliteSorumlusuId = table.Column<int>(type: "int", nullable: false),
                    Hatirlatma = table.Column<bool>(type: "bit", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazKalibrasyonLari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CihazKalibrasyonLari_Cihazlar_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CihazKalibrasyonLari_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    YoneticiId = table.Column<int>(type: "int", nullable: true),
                    DepartmanDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PersonelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.DepartmanID);
                    table.ForeignKey(
                        name: "FK_Departmanlar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    FirmaKodu = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: true),
                    UstYoneticiID = table.Column<int>(type: "int", nullable: true),
                    OnayYetkisi = table.Column<bool>(type: "bit", nullable: false),
                    OnayGrubu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciRolu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personeller_Departmanlar_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departmanlar",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personeller_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personeller_Personeller_UstYoneticiID",
                        column: x => x.UstYoneticiID,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID");
                });

            migrationBuilder.CreateTable(
                name: "DepartmanYoneticileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanId = table.Column<int>(type: "int", nullable: false),
                    YoneticiPersonelId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmanYoneticileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmanYoneticileri_Departmanlar_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmanlar",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmanYoneticileri_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmanYoneticileri_Personeller_YoneticiPersonelId",
                        column: x => x.YoneticiPersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Egitimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    EgitimVeren = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Konusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EgitimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Saat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egitimler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Egitimler_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GelenMalzemeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    MalzemeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tedarikci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Miktar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontrolKriterleri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnayPersonelId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GelenMalzemeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GelenMalzemeler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GelenMalzemeler_Personeller_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vekaletler",
                columns: table => new
                {
                    VekaletID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    VekaletiVerenPersonelId = table.Column<int>(type: "int", nullable: false),
                    VekaletiAlanPersonelId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    vekalet = table.Column<bool>(type: "bit", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vekaletler", x => x.VekaletID);
                    table.ForeignKey(
                        name: "FK_Vekaletler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vekaletler_Personeller_VekaletiAlanPersonelId",
                        column: x => x.VekaletiAlanPersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vekaletler_Personeller_VekaletiVerenPersonelId",
                        column: x => x.VekaletiVerenPersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Onaylar",
                columns: table => new
                {
                    OnayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    DokumanId = table.Column<int>(type: "int", nullable: false),
                    OnaylayanId = table.Column<int>(type: "int", nullable: false),
                    OnayDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnayaGelenTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnayTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onaylar", x => x.OnayId);
                    table.ForeignKey(
                        name: "FK_Onaylar_DepartmanYoneticileri_OnaylayanId",
                        column: x => x.OnaylayanId,
                        principalTable: "DepartmanYoneticileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Onaylar_Dokumanlar_DokumanId",
                        column: x => x.DokumanId,
                        principalTable: "Dokumanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Onaylar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AracBilgileri_FirmaId",
                table: "AracBilgileri",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_AracBilgileri_MusteriId",
                table: "AracBilgileri",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_AracBilgileri_PersonelID",
                table: "AracBilgileri",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_AracForms_AracId",
                table: "AracForms",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_CihazKalibrasyonLari_CihazId",
                table: "CihazKalibrasyonLari",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_CihazKalibrasyonLari_FirmaId",
                table: "CihazKalibrasyonLari",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_CihazKalibrasyonLari_KaliteSorumlusuId",
                table: "CihazKalibrasyonLari",
                column: "KaliteSorumlusuId");

            migrationBuilder.CreateIndex(
                name: "IX_Cihazlar_FirmaId",
                table: "Cihazlar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_FirmaId",
                table: "Departmanlar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_PersonelID",
                table: "Departmanlar",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_YoneticiId",
                table: "Departmanlar",
                column: "YoneticiId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmanYoneticileri_DepartmanId",
                table: "DepartmanYoneticileri",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmanYoneticileri_FirmaId",
                table: "DepartmanYoneticileri",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmanYoneticileri_YoneticiPersonelId",
                table: "DepartmanYoneticileri",
                column: "YoneticiPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimler_FirmaId",
                table: "Egitimler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimler_PersonelId",
                table: "Egitimler",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_FirmaKontrolMaddeleri_FirmaId",
                table: "FirmaKontrolMaddeleri",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotograflar_AracBilgiId",
                table: "Fotograflar",
                column: "AracBilgiId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotograflar_FirmaId",
                table: "Fotograflar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_GelenMalzemeler_FirmaId",
                table: "GelenMalzemeler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_GelenMalzemeler_PersonelID",
                table: "GelenMalzemeler",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_FirmaId",
                table: "Musteriler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Onaylar_DokumanId",
                table: "Onaylar",
                column: "DokumanId");

            migrationBuilder.CreateIndex(
                name: "IX_Onaylar_FirmaId",
                table: "Onaylar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Onaylar_OnaylayanId",
                table: "Onaylar",
                column: "OnaylayanId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_DepartmanID",
                table: "Personeller",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_FirmaId",
                table: "Personeller",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_UstYoneticiID",
                table: "Personeller",
                column: "UstYoneticiID");

            migrationBuilder.CreateIndex(
                name: "IX_Tanimlar_FirmaId",
                table: "Tanimlar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vekaletler_FirmaId",
                table: "Vekaletler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vekaletler_VekaletiAlanPersonelId",
                table: "Vekaletler",
                column: "VekaletiAlanPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vekaletler_VekaletiVerenPersonelId",
                table: "Vekaletler",
                column: "VekaletiVerenPersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AracBilgileri_Personeller_PersonelID",
                table: "AracBilgileri",
                column: "PersonelID",
                principalTable: "Personeller",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CihazKalibrasyonLari_Personeller_KaliteSorumlusuId",
                table: "CihazKalibrasyonLari",
                column: "KaliteSorumlusuId",
                principalTable: "Personeller",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departmanlar_Personeller_PersonelID",
                table: "Departmanlar",
                column: "PersonelID",
                principalTable: "Personeller",
                principalColumn: "PersonelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departmanlar_Personeller_YoneticiId",
                table: "Departmanlar",
                column: "YoneticiId",
                principalTable: "Personeller",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlar_Firmalar_FirmaId",
                table: "Departmanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Personeller_Firmalar_FirmaId",
                table: "Personeller");

            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlar_Personeller_PersonelID",
                table: "Departmanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlar_Personeller_YoneticiId",
                table: "Departmanlar");

            migrationBuilder.DropTable(
                name: "AppVersions");

            migrationBuilder.DropTable(
                name: "AracForms");

            migrationBuilder.DropTable(
                name: "Ayarlar");

            migrationBuilder.DropTable(
                name: "CihazKalibrasyonLari");

            migrationBuilder.DropTable(
                name: "Egitimler");

            migrationBuilder.DropTable(
                name: "FirmaKontrolMaddeleri");

            migrationBuilder.DropTable(
                name: "Fotograflar");

            migrationBuilder.DropTable(
                name: "GelenMalzemeler");

            migrationBuilder.DropTable(
                name: "Onaylar");

            migrationBuilder.DropTable(
                name: "Tanimlar");

            migrationBuilder.DropTable(
                name: "Vekaletler");

            migrationBuilder.DropTable(
                name: "Cihazlar");

            migrationBuilder.DropTable(
                name: "AracBilgileri");

            migrationBuilder.DropTable(
                name: "DepartmanYoneticileri");

            migrationBuilder.DropTable(
                name: "Dokumanlar");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Firmalar");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Departmanlar");
        }
    }
}
