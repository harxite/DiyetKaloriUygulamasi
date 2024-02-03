using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDiet.DAL.Migrations
{
    public partial class InitDietApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AksamYemekleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlinanToplamKalori = table.Column<int>(type: "int", nullable: false),
                    AlinanToplamYag = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamProtein = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamKarbonhidrat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AksamYemekleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AraOgunler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlinanToplamKalori = table.Column<int>(type: "int", nullable: false),
                    AlinanToplamYag = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamProtein = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamKarbonhidrat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AraOgunler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kategori = table.Column<int>(type: "int", nullable: false),
                    PorsiyonBirimi = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", maxLength: 3, nullable: true),
                    YagMiktari = table.Column<double>(type: "float", maxLength: 3, nullable: true),
                    KarbonhidratMiktari = table.Column<double>(type: "float", maxLength: 3, nullable: true),
                    OnayliMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DegistirilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kahvaltilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlinanToplamKalori = table.Column<int>(type: "int", nullable: false),
                    AlinanToplamYag = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamProtein = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamKarbonhidrat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kahvaltilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Yas = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Kilo = table.Column<double>(type: "float", maxLength: 3, nullable: false),
                    AktiviteDuzeyi = table.Column<int>(type: "int", nullable: false),
                    HedefKilo = table.Column<double>(type: "float", maxLength: 3, nullable: false),
                    KullaniciTipi = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DegistirilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OgleYemekleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlinanToplamKalori = table.Column<int>(type: "int", nullable: false),
                    AlinanToplamYag = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamProtein = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamKarbonhidrat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgleYemekleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AksamYemegiBesin",
                columns: table => new
                {
                    AksamYemekleriID = table.Column<int>(type: "int", nullable: false),
                    BesinlerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AksamYemegiBesin", x => new { x.AksamYemekleriID, x.BesinlerID });
                    table.ForeignKey(
                        name: "FK_AksamYemegiBesin_AksamYemekleri_AksamYemekleriID",
                        column: x => x.AksamYemekleriID,
                        principalTable: "AksamYemekleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AksamYemegiBesin_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AraOgunBesin",
                columns: table => new
                {
                    AraOgunlerID = table.Column<int>(type: "int", nullable: false),
                    BesinlerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AraOgunBesin", x => new { x.AraOgunlerID, x.BesinlerID });
                    table.ForeignKey(
                        name: "FK_AraOgunBesin_AraOgunler_AraOgunlerID",
                        column: x => x.AraOgunlerID,
                        principalTable: "AraOgunler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AraOgunBesin_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinKahvalti",
                columns: table => new
                {
                    BesinlerID = table.Column<int>(type: "int", nullable: false),
                    KahvaltilarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinKahvalti", x => new { x.BesinlerID, x.KahvaltilarID });
                    table.ForeignKey(
                        name: "FK_BesinKahvalti_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinKahvalti_Kahvaltilar_KahvaltilarID",
                        column: x => x.KahvaltilarID,
                        principalTable: "Kahvaltilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinOgleYemegi",
                columns: table => new
                {
                    BesinlerID = table.Column<int>(type: "int", nullable: false),
                    OgleYemekleriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinOgleYemegi", x => new { x.BesinlerID, x.OgleYemekleriID });
                    table.ForeignKey(
                        name: "FK_BesinOgleYemegi_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinOgleYemegi_OgleYemekleri_OgleYemekleriID",
                        column: x => x.OgleYemekleriID,
                        principalTable: "OgleYemekleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukDetaylar",
                columns: table => new
                {
                    GunlukDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GunlukKaloriIhtiyaci = table.Column<int>(type: "int", nullable: false),
                    AlinanToplamKalori = table.Column<int>(type: "int", nullable: false),
                    AlinanToplamYag = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamProtein = table.Column<double>(type: "float", nullable: false),
                    AlinanToplamKarbonhidrat = table.Column<double>(type: "float", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KahvaltiID = table.Column<int>(type: "int", nullable: true),
                    OgleYemegiID = table.Column<int>(type: "int", nullable: true),
                    AksamYemegiID = table.Column<int>(type: "int", nullable: true),
                    AraOgunID = table.Column<int>(type: "int", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukDetaylar", x => x.GunlukDetayId);
                    table.ForeignKey(
                        name: "FK_GunlukDetaylar_AksamYemekleri_AksamYemegiID",
                        column: x => x.AksamYemegiID,
                        principalTable: "AksamYemekleri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_GunlukDetaylar_AraOgunler_AraOgunID",
                        column: x => x.AraOgunID,
                        principalTable: "AraOgunler",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_GunlukDetaylar_Kahvaltilar_KahvaltiID",
                        column: x => x.KahvaltiID,
                        principalTable: "Kahvaltilar",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_GunlukDetaylar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunlukDetaylar_OgleYemekleri_OgleYemegiID",
                        column: x => x.OgleYemegiID,
                        principalTable: "OgleYemekleri",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Aciklama", "Ad", "DegistirilmeTarihi", "Durum", "Fotograf", "Kalori", "KarbonhidratMiktari", "Kategori", "Miktar", "OlusturulmaTarihi", "OnayliMi", "PorsiyonBirimi", "ProteinMiktari", "SilinmeTarihi", "YagMiktari" },
                values: new object[,]
                {
                    { 1, "Yağsız tavuk göğsü.", "Tavuk Göğsü", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\TavukGogsu.jpg", 120, 12.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5033), true, 3, 12.0, null, 12.0 },
                    { 2, "Beyaz pilav.", "Pilav", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\TavukGogsu\\Pilav.jpg", 150, 30.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5050), true, 3, 3.0, null, 1.0 },
                    { 3, "Sulu yapılan yeşil mercimek yemeği", "Yeşil Mercimek", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YesilMercimek.jpg", 180, 5.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5053), true, 3, 20.0, null, 10.0 },
                    { 4, "Izgara yağsız somon", "Somon", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Somon.jpg", 80, 15.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5056), true, 3, 5.0, null, 2.0 },
                    { 5, "Fırında karnabahar grateni.", "Karnabahar Graten", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Karnabahar.jpg", 120, 10.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5058), true, 3, 8.0, null, 7.0 },
                    { 6, "Baharatlı ve nefis fırın tavuk.", "Pirzola", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Pirzola.jpg", 200, 0.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5060), true, 3, 25.0, null, 12.0 },
                    { 7, "Sebzelerle zenginleştirilmiş kıymalı pilav.", "Sebzeli Kıymalı Pilav", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\SebzeliEtliPilav.jpg", 180, 20.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5070), true, 3, 10.0, null, 8.0 },
                    { 8, "Izgara köfte yanında yeşillik.", "Köfte Izgara", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Kofte.jpg", 160, 5.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5073), true, 3, 15.0, null, 9.0 },
                    { 9, "Fırında pişirilmiş nefis balık tava.", "Balık Tava", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\BalikTava.jpg", 150, 2.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5076), true, 3, 20.0, null, 8.0 },
                    { 10, "Yavaş pişirilmiş nefis kuzu tandır.", "Kuzu Tandır", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Tandir.jpg", 250, 5.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5078), true, 3, 30.0, null, 15.0 },
                    { 11, "Patlıcan ile yapılan etli bir yemek", "Kıymalı Musakka", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KiymaliMusakka.jpg", 180, 0.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5083), true, 3, 25.0, null, 10.0 },
                    { 12, "Et ve bulgurun muhteşem uyumu.", "Etli Bulgur Pilavı", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\EtliBulgur.jpg", 220, 30.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5086), true, 3, 15.0, null, 8.0 },
                    { 13, "Tavuk ve taze sebzelerle hazırlanan nefis güveç.", "Sebzeli Tavuk Güveç", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\GuvecteTavuk.jpg", 200, 15.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5088), true, 3, 20.0, null, 12.0 },
                    { 14, "Geleneksel zeytinyağlı yaprak sarması.", "Zeytinyağlı Yaprak Sarma", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\ZeytinyagliSarma.jpg", 120, 15.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5090), true, 2, 2.0, null, 6.0 },
                    { 15, "Hafif ve nefis karnabahar kızartması.", "Karnabahar Kızartması", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KarnabaharKizartma.jpg", 150, 10.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5093), true, 3, 5.0, null, 8.0 },
                    { 16, "Taze ve lezzetli bir elma.", "Elma", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Elma.jpg", 50, 12.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5095), true, 2, 1.0, null, 0.0 },
                    { 17, "Yogurt soslu taze salatalık dilimleri.", "Yogurtlu Salatalık", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YogurtluSalatalik.jpg", 30, 5.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5098), true, 3, 2.0, null, 1.0 },
                    { 18, "Sağlıklı badem atıştırmalığı.", "Badem", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Badem.jpg", 100, 3.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5100), true, 3, 4.0, null, 9.0 },
                    { 19, "Meyve olarak tüketilebilecek muz.", "Muz", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Muz.jpg", 120, 30.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5102), true, 2, 1.0, null, 0.0 },
                    { 20, "Süt veya yoğurt ile tüketilebilecek yulaf ezmesi.", "Yulaf Ezmesi", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YulafEzmesi.jpg", 150, 30.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5105), true, 3, 5.0, null, 2.0 },
                    { 21, "Hindi dilimleri ve havuç dilimleri.", "Hindi Dilimleri ve Havuç", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\HindiDilimiHavuc.jpg", 80, 5.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5107), true, 3, 15.0, null, 2.0 },
                    { 22, "Yumurta, ıspanak, biber ve domates içeren hafif bir omlet.", "Sebzeli Omlet", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\sebzeliomlet", 140, 2.5, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5109), true, 3, 10.6, null, 9.5 },
                    { 23, "Çeşitli taze meyvelerden oluşan hafif bir meyve salatası.", "Taze Meyve Salatası", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\tazemeyvesalatasi", 43, 11.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5112), true, 4, 0.5, null, 0.29999999999999999 },
                    { 24, "Yoğurt ile karıştırılmış müsli, ceviz ve bal ile zenginleştirilmiş bir kahvaltı seçeneği.", "Yoğurtlu Müsli", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\yogurtlumusli", 250, 37.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5114), true, 4, 8.5, null, 7.0 },
                    { 25, "Mısır gevreği süt ile servis edilen hafif ve pratik bir kahvaltı seçeneği.", "Mısır Gevreği ve Süt", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\misirgevregivesut", 150, 30.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5117), true, 4, 5.0, null, 1.0 },
                    { 26, "Beyaz peynir, domates ve salatalık dilimleri ile hazırlanan nefis bir kahvaltılık tost.", "Tost", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\tost", 200, 25.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5119), true, 2, 8.0, null, 9.0 },
                    { 27, "Yulaf, kuruyemiş ve bal içeren enerji dolu granola bar.", "Granola Bar", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\granolabar", 180, 22.0, 5, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5121), true, 2, 4.0, null, 9.0 },
                    { 28, "Taze beyaz peynir ve zeytinlerden oluşan geleneksel bir Türk kahvaltısı.", "Beyaz Peynir ve Zeytin", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\beyazpeynirvezeytin", 220, 2.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5205), true, 3, 10.0, null, 18.0 },
                    { 29, "Somon dilimleri, krem peynir ve taze yeşilliklerle doldurulmuş lezzetli bir bagel.", "Somonlu Bagel", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\somonlubagel", 250, 30.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5209), true, 2, 12.0, null, 10.0 },
                    { 30, "Haşlanmış yumurta dilimleri ve marullarla hazırlanan pratik bir sandviç.", "Yumurtalı Sandviç", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\yumurtalisandvic", 180, 15.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5211), true, 2, 12.0, null, 8.0 },
                    { 31, "Protein tozu, süt ve meyve içeren besleyici bir protein shake.", "Proteinli Shake", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\proteinlishake", 180, 15.0, 3, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5213), true, 3, 20.0, null, 5.0 },
                    { 32, "Ton balığı, marullar ve mayonez ile hazırlanan sağlıklı bir kahvaltı sandviçi.", "Ton Balıklı Sandviç", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\tonbaliklisandvic", 250, 20.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5215), true, 2, 15.0, null, 12.0 },
                    { 33, "Yulaf unu, protein tozu ve doğranmış muz içeren yüksek proteinli pancake.", "Muzlu Proteinli Pancake", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\muzluproteinlipancake", 280, 30.0, 5, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5218), true, 2, 20.0, null, 10.0 },
                    { 34, "Yumurta, domates ve beyaz peynir içeren nefis bir omlet.", "Domates ve Peynirli Omlet", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\domatesvepeynirliomlet", 180, 4.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5220), true, 3, 12.0, null, 14.0 },
                    { 35, "Sarımsaklı peynir ve taze yeşilliklerle doldurulmuş hafif bir baget.", "Sarımsaklı Peynirli Baget", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\sarimsaklipeynirlibaget", 220, 28.0, 6, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5222), true, 2, 10.0, null, 12.0 },
                    { 36, "Sağlıklı yağlar ve doğal şeker içeren enerji dolu bir ara öğün.", "Badem ve Kuru Üzüm Karışımı", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\bademvekuruuzumkarisimi", 180, 15.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5224), true, 3, 5.0, null, 12.0 },
                    { 37, "Taze meyvelerle süslenmiş yoğurtlu hafif bir ara öğün seçeneği.", "Yoğurtlu Meyve Parçacıkları", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\yogurtlumeyveparcaciklari", 120, 25.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5226), true, 4, 3.0, null, 1.0 },
                    { 38, "Havuç dilimleri ile lezzetli humus, vitamin ve protein içeren bir ara öğün alternatifi.", "Havuç ve Humus", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\havucvehumus", 150, 20.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5228), true, 4, 5.0, null, 7.0 },
                    { 39, "Ceviz ve kuru incir karışımı, lif ve sağlıklı yağlar içeren doyurucu bir ara öğün.", "Ceviz ve Kuru İncir", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\cevizvekuruincir", 200, 20.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5230), true, 3, 5.0, null, 15.0 },
                    { 40, "Taze mandalina dilimleri, C vitamini kaynağı olan hafif bir ara öğün seçeneği.", "Mandalina Dilimleri", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\mandalinadilimleri", 50, 12.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5232), true, 5, 1.0, null, 0.5 },
                    { 41, "Izgara tavuk yanında sebzeler.", "Tavuk Izgara", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\IzgaraTavuk.jpg", 165, 0.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5234), true, 3, 31.0, null, 3.6000000000000001 },
                    { 42, "Izgara balık yanında ızgara sebzeler.", "Balık Izgara", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\BalikIzgara.jpg", 136, 0.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5236), true, 3, 25.0, null, 3.3999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Aciklama", "Ad", "DegistirilmeTarihi", "Durum", "Fotograf", "Kalori", "KarbonhidratMiktari", "Kategori", "Miktar", "OlusturulmaTarihi", "OnayliMi", "PorsiyonBirimi", "ProteinMiktari", "SilinmeTarihi", "YagMiktari" },
                values: new object[,]
                {
                    { 43, "Kıymalı ıspanak yemeği yanında pilav.", "Kıyma Ispanak", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KiymaIspanak.jpg", 190, 15.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5241), true, 3, 10.0, null, 12.0 },
                    { 44, "Ceviz ve kuru kayısı karışımı.", "Ceviz ve Kuru Kayısı Karışımı", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\CevizKuruKayisi.jpg", 140, 10.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5243), true, 3, 4.0, null, 11.0 },
                    { 45, "Sebzeli tavuk sote yanında bulgur pilavı.", "Sebzeli Tavuk Sote", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\SebzeliTavukSote.jpg", 180, 20.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5246), true, 3, 25.0, null, 8.0 },
                    { 46, "Mercimek köftesi yanında marullarla servis edilir.", "Mercimek Köftesi", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MercimekKoftesi.jpg", 120, 25.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5248), true, 3, 7.0, null, 1.0 },
                    { 47, "Kinoa salatası yanında avokado dilimleri.", "Kinoa Salatası", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KinoaSalatasi.jpg", 200, 25.0, 1, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5250), true, 1, 10.0, null, 8.0 },
                    { 48, "Mantarlı tavuk yanında bulgur pilavı.", "Mantarlı Tavuk", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MantarliTavuk.jpg", 180, 20.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5253), true, 3, 22.0, null, 9.0 },
                    { 49, "Kırmızı mercimek çorbası yanında ekmek.", "Kırmızı Mercimek Çorbası", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MercimekCorbasi.jpg", 120, 20.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5254), true, 4, 7.0, null, 1.0 },
                    { 50, "Karnabahar graten yanında salata.", "Karnabahar Graten", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KarnabaharGraten.jpg", 150, 12.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5267), true, 3, 8.0, null, 10.0 },
                    { 51, "Kıymalı kabak yemeği yanında pilav.", "Kıymalı Kabak Yemeği", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KiymaliKabak.jpg", 180, 20.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5269), true, 3, 15.0, null, 8.0 },
                    { 53, "Fırın tavuk kanat yanında patates kızartması.", "Fırın Tavuk Kanat", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\FirinTavukKanat.jpg", 180, 15.0, 2, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5271), true, 2, 20.0, null, 10.0 },
                    { 54, "Mevsim salatası yanında hindi dilimleri.", "Mevsim Salatası", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MevsimSalatasi.jpg", 120, 15.0, 1, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5273), true, 1, 8.0, null, 5.0 },
                    { 55, "Kumpir yanında garnitürlerle servis edilir.", "Kumpir", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Kumpir.jpg", 250, 30.0, 7, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5275), true, 1, 10.0, null, 12.0 },
                    { 56, "Ton balıklı salata yanında zeytinyağlı sos.", "Ton Balıklı Salata", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\TonBalikliSalata.jpg", 180, 15.0, 1, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5277), true, 1, 20.0, null, 8.0 },
                    { 57, "Muz ve yulaf ezmesi içeren smoothie.", "Muz ve Yulaf Ezmesi Smoothie", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MuzYulafSmoothie.jpg", 150, 30.0, 8, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5279), true, 3, 5.0, null, 2.0 },
                    { 58, "Yoğurtlu meyve salatası.", "Yoğurtlu Meyve Salatası", null, 0, "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YogurluMeyveSalatasi.jpg", 100, 20.0, 1, 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5281), true, 1, 3.0, null, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "ID", "Ad", "AktifMi", "AktiviteDuzeyi", "Boy", "Cinsiyet", "DegistirilmeTarihi", "Durum", "Email", "HedefKilo", "Kilo", "KullaniciTipi", "OlusturulmaTarihi", "Sifre", "SilinmeTarihi", "Soyad", "Yas" },
                values: new object[] { 1, "Admin", true, 4, 180, 2, null, 1, "admin@dietapp.com", 71.0, 70.0, 1, new DateTime(2023, 12, 1, 16, 59, 9, 839, DateTimeKind.Local).AddTicks(144), "admin54321", null, "Admin", 25 });

            migrationBuilder.CreateIndex(
                name: "IX_AksamYemegiBesin_BesinlerID",
                table: "AksamYemegiBesin",
                column: "BesinlerID");

            migrationBuilder.CreateIndex(
                name: "IX_AraOgunBesin_BesinlerID",
                table: "AraOgunBesin",
                column: "BesinlerID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinKahvalti_KahvaltilarID",
                table: "BesinKahvalti",
                column: "KahvaltilarID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgleYemegi_OgleYemekleriID",
                table: "BesinOgleYemegi",
                column: "OgleYemekleriID");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukDetaylar_AksamYemegiID",
                table: "GunlukDetaylar",
                column: "AksamYemegiID");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukDetaylar_AraOgunID",
                table: "GunlukDetaylar",
                column: "AraOgunID");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukDetaylar_KahvaltiID",
                table: "GunlukDetaylar",
                column: "KahvaltiID");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukDetaylar_KullaniciId",
                table: "GunlukDetaylar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukDetaylar_OgleYemegiID",
                table: "GunlukDetaylar",
                column: "OgleYemegiID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_Email",
                table: "Kullanicilar",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AksamYemegiBesin");

            migrationBuilder.DropTable(
                name: "AraOgunBesin");

            migrationBuilder.DropTable(
                name: "BesinKahvalti");

            migrationBuilder.DropTable(
                name: "BesinOgleYemegi");

            migrationBuilder.DropTable(
                name: "GunlukDetaylar");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "AksamYemekleri");

            migrationBuilder.DropTable(
                name: "AraOgunler");

            migrationBuilder.DropTable(
                name: "Kahvaltilar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "OgleYemekleri");
        }
    }
}
