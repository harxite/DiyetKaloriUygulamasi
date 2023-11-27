using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.DAL.Configurations
{
    internal class BesinConfiguration : IEntityTypeConfiguration<Besin>
    {
        public void Configure(EntityTypeBuilder<Besin> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(50);
            builder.Property(x => x.Aciklama).HasMaxLength(255);
            builder.Property(x => x.Kalori).HasMaxLength(5);
            builder.Property(x => x.ProteinMiktari).HasMaxLength(3);
            builder.Property(x => x.YagMiktari).HasMaxLength(3);
            builder.Property(x => x.KarbonhidratMiktari).HasMaxLength(3);

            builder.HasData(
                new Besin
                {
                    ID = 1,
                    Ad = "Tavuk Göğsü",
                    Aciklama = "Yağsız tavuk göğsü.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 120,
                    KarbonhidratMiktari = 12,
                    ProteinMiktari = 12,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\TavukGogsu.jpg"

                },
                new Besin
                {
                    ID = 2,
                    Ad = "Pilav",
                    Aciklama = "Beyaz pilav.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 150,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 3,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\TavukGogsu\\Pilav.jpg"
                },
                new Besin
                {
                    ID = 3,
                    Ad = "Yeşil Mercimek",
                    Aciklama = "Sulu yapılan yeşil mercimek yemeği",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 5,
                    ProteinMiktari = 20,
                    YagMiktari = 10,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YesilMercimek.jpg"
                },
                new Besin
                {
                    ID = 4,
                    Ad = "Somon",
                    Aciklama = "Izgara yağsız somon",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 80,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 5,
                    YagMiktari = 2,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Somon.jpg"
                },
                new Besin
                {
                    ID = 5,
                    Ad = "Karnabahar Graten",
                    Aciklama = "Fırında karnabahar grateni.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 120,
                    KarbonhidratMiktari = 10,
                    ProteinMiktari = 8,
                    YagMiktari = 7,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Karnabahar.jpg"
                },
                new Besin
                {
                    ID = 6,
                    Ad = "Pirzola",
                    Aciklama = "Baharatlı ve nefis fırın tavuk.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 200,
                    KarbonhidratMiktari = 0,
                    ProteinMiktari = 25,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Pirzola.jpg"
                },
                new Besin
                {
                    ID = 7,
                    Ad = "Sebzeli Kıymalı Pilav",
                    Aciklama = "Sebzelerle zenginleştirilmiş kıymalı pilav.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 10,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\SebzeliEtliPilav.jpg"
                },
                new Besin
                {
                    ID = 8,
                    Ad = "Köfte Izgara",
                    Aciklama = "Izgara köfte yanında yeşillik.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 160,
                    KarbonhidratMiktari = 5,
                    ProteinMiktari = 15,
                    YagMiktari = 9,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Kofte.jpg"
                },
                new Besin
                {
                    ID = 9,
                    Ad = "Balık Tava",
                    Aciklama = "Fırında pişirilmiş nefis balık tava.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 150,
                    KarbonhidratMiktari = 2,
                    ProteinMiktari = 20,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\BalikTava.jpg"
                },
                new Besin
                {
                    ID = 10,
                    Ad = "Kuzu Tandır",
                    Aciklama = "Yavaş pişirilmiş nefis kuzu tandır.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 250,
                    KarbonhidratMiktari = 5,
                    ProteinMiktari = 30,
                    YagMiktari = 15,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Tandir.jpg"
                },
                new Besin
                {
                    ID = 11,
                    Ad = "Kıymalı Musakka",
                    Aciklama = "Patlıcan ile yapılan etli bir yemek",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 0,
                    ProteinMiktari = 25,
                    YagMiktari = 10,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KiymaliMusakka.jpg",
                    Kategori = Kategori.AnaYemek
                },
                new Besin
                {
                    ID = 12,
                    Ad = "Etli Bulgur Pilavı",
                    Aciklama = "Et ve bulgurun muhteşem uyumu.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 220,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 15,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\EtliBulgur.jpg",
                    Kategori = Kategori.AnaYemek
                },
                new Besin
                {
                    ID = 13,
                    Ad = "Sebzeli Tavuk Güveç",
                    Aciklama = "Tavuk ve taze sebzelerle hazırlanan nefis güveç.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 200,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 20,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\GuvecteTavuk.jpg",
                    Kategori = Kategori.AnaYemek
                },
                new Besin
                {
                    ID = 14,
                    Ad = "Zeytinyağlı Yaprak Sarma",
                    Aciklama = "Geleneksel zeytinyağlı yaprak sarması.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 120,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 2,
                    YagMiktari = 6,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\ZeytinyagliSarma.jpg",
                    Kategori = Kategori.AnaYemek
                },
                new Besin
                {
                    ID = 15,
                    Ad = "Karnabahar Kızartması",
                    Aciklama = "Hafif ve nefis karnabahar kızartması.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 150,
                    KarbonhidratMiktari = 10,
                    ProteinMiktari = 5,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KarnabaharKizartma.jpg",
                    Kategori = Kategori.AnaYemek
                },
                new Besin
                {
                    ID = 16,
                    Ad = "Elma",
                    Aciklama = "Taze ve lezzetli bir elma.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 50,
                    KarbonhidratMiktari = 12,
                    ProteinMiktari = 1,
                    YagMiktari = 0,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Elma.jpg",
                    Kategori = Kategori.Aperatif
                },
                new Besin
                {
                    ID = 17,
                    Ad = "Yogurtlu Salatalık",
                    Aciklama = "Yogurt soslu taze salatalık dilimleri.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 30,
                    KarbonhidratMiktari = 5,
                    ProteinMiktari = 2,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YogurtluSalatalik.jpg",
                    Kategori = Kategori.Aperatif
                },
                new Besin
                {
                    ID = 18,
                    Ad = "Badem",
                    Aciklama = "Sağlıklı badem atıştırmalığı.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 100,
                    KarbonhidratMiktari = 3,
                    ProteinMiktari = 4,
                    YagMiktari = 9,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Badem.jpg",
                    Kategori = Kategori.Aperatif
                },
                new Besin
                {
                    ID = 19,
                    Ad = "Muz",
                    Aciklama = "Meyve olarak tüketilebilecek muz.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 120,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 1,
                    YagMiktari = 0,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Muz.jpg",
                    Kategori = Kategori.Aperatif
                },
                new Besin
                {
                    ID = 20,
                    Ad = "Yulaf Ezmesi",
                    Aciklama = "Süt veya yoğurt ile tüketilebilecek yulaf ezmesi.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 150,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 5,
                    YagMiktari = 2,
                    OnayliMi = true,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YulafEzmesi.jpg",
                    Kategori = Kategori.Aperatif
                },
                new Besin
                {
                    ID = 21,
                    Ad = "Hindi Dilimleri ve Havuç",
                    Aciklama = "Hindi dilimleri ve havuç dilimleri.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 80,
                    KarbonhidratMiktari = 5,
                    ProteinMiktari = 15,
                    YagMiktari = 2,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\HindiDilimiHavuc.jpg"
                },
                new Besin
                {
                    ID = 22,
                    Ad = "Sebzeli Omlet",
                    Aciklama = "Yumurta, ıspanak, biber ve domates içeren hafif bir omlet.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 140,
                    KarbonhidratMiktari = 2.5,
                    ProteinMiktari = 10.6,
                    YagMiktari = 9.5,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\sebzeliomlet"
                },

                new Besin
                {
                    ID = 23,
                    Ad = "Taze Meyve Salatası",
                    Aciklama = "Çeşitli taze meyvelerden oluşan hafif bir meyve salatası.",
                    PorsiyonBirimi = PorsiyonBirimi.Kase,
                    Kalori = 43,
                    KarbonhidratMiktari = 11,
                    ProteinMiktari = 0.5,
                    YagMiktari = 0.3,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\tazemeyvesalatasi"
                },

                new Besin
                {
                    ID = 24,
                    Ad = "Yoğurtlu Müsli",
                    Aciklama = "Yoğurt ile karıştırılmış müsli, ceviz ve bal ile zenginleştirilmiş bir kahvaltı seçeneği.",
                    PorsiyonBirimi = PorsiyonBirimi.Kase,
                    Kalori = 250,
                    KarbonhidratMiktari = 37,
                    ProteinMiktari = 8.5,
                    YagMiktari = 7,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\yogurtlumusli"
                },

                new Besin
                {
                    ID = 25,
                    Ad = "Mısır Gevreği ve Süt",
                    Aciklama = "Mısır gevreği süt ile servis edilen hafif ve pratik bir kahvaltı seçeneği.",
                    PorsiyonBirimi = PorsiyonBirimi.Kase,
                    Kalori = 150,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 5,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\misirgevregivesut"
                },

                new Besin
                {
                    ID = 26,
                    Ad = "Tost",
                    Aciklama = "Beyaz peynir, domates ve salatalık dilimleri ile hazırlanan nefis bir kahvaltılık tost.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 200,
                    KarbonhidratMiktari = 25,
                    ProteinMiktari = 8,
                    YagMiktari = 9,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\tost"
                },

                new Besin
                {
                    ID = 27,
                    Ad = "Granola Bar",
                    Aciklama = "Yulaf, kuruyemiş ve bal içeren enerji dolu granola bar.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 180,
                    KarbonhidratMiktari = 22,
                    ProteinMiktari = 4,
                    YagMiktari = 9,
                    OnayliMi = true,
                    Kategori = Kategori.Atistirmalik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\granolabar"
                },

                new Besin
                {
                    ID = 28,
                    Ad = "Beyaz Peynir ve Zeytin",
                    Aciklama = "Taze beyaz peynir ve zeytinlerden oluşan geleneksel bir Türk kahvaltısı.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 220,
                    KarbonhidratMiktari = 2,
                    ProteinMiktari = 10,
                    YagMiktari = 18,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\beyazpeynirvezeytin"
                },

                new Besin
                {
                    ID = 29,
                    Ad = "Somonlu Bagel",
                    Aciklama = "Somon dilimleri, krem peynir ve taze yeşilliklerle doldurulmuş lezzetli bir bagel.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 250,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 12,
                    YagMiktari = 10,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\somonlubagel"
                },

                new Besin
                {
                    ID = 30,
                    Ad = "Yumurtalı Sandviç",
                    Aciklama = "Haşlanmış yumurta dilimleri ve marullarla hazırlanan pratik bir sandviç.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 180,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 12,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\yumurtalisandvic"
                },

                new Besin
                {
                    ID = 31,
                    Ad = "Proteinli Shake",
                    Aciklama = "Protein tozu, süt ve meyve içeren besleyici bir protein shake.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 20,
                    YagMiktari = 5,
                    OnayliMi = true,
                    Kategori = Kategori.Icecek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\proteinlishake"
                },

                new Besin
                {
                    ID = 32,
                    Ad = "Ton Balıklı Sandviç",
                    Aciklama = "Ton balığı, marullar ve mayonez ile hazırlanan sağlıklı bir kahvaltı sandviçi.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 250,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 15,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\tonbaliklisandvic"
                },

                new Besin
                {
                    ID = 33,
                    Ad = "Muzlu Proteinli Pancake",
                    Aciklama = "Yulaf unu, protein tozu ve doğranmış muz içeren yüksek proteinli pancake.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 280,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 20,
                    YagMiktari = 10,
                    OnayliMi = true,
                    Kategori = Kategori.Atistirmalik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\muzluproteinlipancake"
                },

                new Besin
                {
                    ID = 34,
                    Ad = "Domates ve Peynirli Omlet",
                    Aciklama = "Yumurta, domates ve beyaz peynir içeren nefis bir omlet.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 4,
                    ProteinMiktari = 12,
                    YagMiktari = 14,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\domatesvepeynirliomlet"
                },

                new Besin
                {
                    ID = 35,
                    Ad = "Sarımsaklı Peynirli Baget",
                    Aciklama = "Sarımsaklı peynir ve taze yeşilliklerle doldurulmuş hafif bir baget.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 220,
                    KarbonhidratMiktari = 28,
                    ProteinMiktari = 10,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.Kahvaltilik,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\sarimsaklipeynirlibaget"
                },

                new Besin
                {
                    ID = 36,
                    Ad = "Badem ve Kuru Üzüm Karışımı",
                    Aciklama = "Sağlıklı yağlar ve doğal şeker içeren enerji dolu bir ara öğün.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 5,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\bademvekuruuzumkarisimi"
                },

                new Besin
                {
                    ID = 37,
                    Ad = "Yoğurtlu Meyve Parçacıkları",
                    Aciklama = "Taze meyvelerle süslenmiş yoğurtlu hafif bir ara öğün seçeneği.",
                    PorsiyonBirimi = PorsiyonBirimi.Kase,
                    Kalori = 120,
                    KarbonhidratMiktari = 25,
                    ProteinMiktari = 3,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\yogurtlumeyveparcaciklari"
                },

                new Besin
                {
                    ID = 38,
                    Ad = "Havuç ve Humus",
                    Aciklama = "Havuç dilimleri ile lezzetli humus, vitamin ve protein içeren bir ara öğün alternatifi.",
                    PorsiyonBirimi = PorsiyonBirimi.Kase,
                    Kalori = 150,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 5,
                    YagMiktari = 7,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\havucvehumus"
                },

                new Besin
                {
                    ID = 39,
                    Ad = "Ceviz ve Kuru İncir",
                    Aciklama = "Ceviz ve kuru incir karışımı, lif ve sağlıklı yağlar içeren doyurucu bir ara öğün.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 200,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 5,
                    YagMiktari = 15,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\cevizvekuruincir"
                },

                new Besin
                {
                    ID = 40,
                    Ad = "Mandalina Dilimleri",
                    Aciklama = "Taze mandalina dilimleri, C vitamini kaynağı olan hafif bir ara öğün seçeneği.",
                    PorsiyonBirimi = PorsiyonBirimi.Dilim,
                    Kalori = 50,
                    KarbonhidratMiktari = 12,
                    ProteinMiktari = 1,
                    YagMiktari = 0.5,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\mandalinadilimleri"
                },
                new Besin
                {
                    ID = 41,
                    Ad = "Tavuk Izgara",
                    Aciklama = "Izgara tavuk yanında sebzeler.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 165,
                    KarbonhidratMiktari = 0,
                    ProteinMiktari = 31,
                    YagMiktari = 3.6,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\IzgaraTavuk.jpg"
                },
                new Besin
                {
                    ID = 42,
                    Ad = "Balık Izgara",
                    Aciklama = "Izgara balık yanında ızgara sebzeler.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 136,
                    KarbonhidratMiktari = 0,
                    ProteinMiktari = 25,
                    YagMiktari = 3.4,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\BalikIzgara.jpg"
                },
                new Besin
                {
                    ID = 43,
                    Ad = "Kıyma Ispanak",
                    Aciklama = "Kıymalı ıspanak yemeği yanında pilav.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 190,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 10,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KiymaIspanak.jpg"
                },
                new Besin
                {
                    ID = 44,
                    Ad = "Ceviz ve Kuru Kayısı Karışımı",
                    Aciklama = "Ceviz ve kuru kayısı karışımı.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 140,
                    KarbonhidratMiktari = 10,
                    ProteinMiktari = 4,
                    YagMiktari = 11,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\CevizKuruKayisi.jpg"
                },
                new Besin
                {
                    ID = 45,
                    Ad = "Sebzeli Tavuk Sote",
                    Aciklama = "Sebzeli tavuk sote yanında bulgur pilavı.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 25,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\SebzeliTavukSote.jpg"
                },
                new Besin
                {
                    ID = 46,
                    Ad = "Mercimek Köftesi",
                    Aciklama = "Mercimek köftesi yanında marullarla servis edilir.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 120,
                    KarbonhidratMiktari = 25,
                    ProteinMiktari = 7,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MercimekKoftesi.jpg"
                },
                new Besin
                {
                    ID = 47,
                    Ad = "Kinoa Salatası",
                    Aciklama = "Kinoa salatası yanında avokado dilimleri.",
                    PorsiyonBirimi = PorsiyonBirimi.Porsiyon,
                    Kalori = 200,
                    KarbonhidratMiktari = 25,
                    ProteinMiktari = 10,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.Salata,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KinoaSalatasi.jpg"
                },
                new Besin
                {
                    ID = 48,
                    Ad = "Mantarlı Tavuk",
                    Aciklama = "Mantarlı tavuk yanında bulgur pilavı.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 22,
                    YagMiktari = 9,
                    OlusturulmaTarihi = DateTime.Now,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MantarliTavuk.jpg"
                },
                new Besin
                {
                    ID = 49,
                    Ad = "Kırmızı Mercimek Çorbası",
                    Aciklama = "Kırmızı mercimek çorbası yanında ekmek.",
                    PorsiyonBirimi = PorsiyonBirimi.Kase,
                    Kalori = 120,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 7,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Kategori = Kategori.Corba,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MercimekCorbasi.jpg"
                },
                new Besin
                {
                    ID = 50,
                    Ad = "Karnabahar Graten",
                    Aciklama = "Karnabahar graten yanında salata.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 150,
                    KarbonhidratMiktari = 12,
                    ProteinMiktari = 8,
                    YagMiktari = 10,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KarnabaharGraten.jpg"
                },
                new Besin
                {
                    ID = 51,
                    Ad = "Kıymalı Kabak Yemeği",
                    Aciklama = "Kıymalı kabak yemeği yanında pilav.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 180,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 15,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\KiymaliKabak.jpg"
                },
                new Besin
                {
                    ID = 53,
                    Ad = "Fırın Tavuk Kanat",
                    Aciklama = "Fırın tavuk kanat yanında patates kızartması.",
                    PorsiyonBirimi = PorsiyonBirimi.Adet,
                    Kalori = 180,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 20,
                    YagMiktari = 10,
                    OnayliMi = true,
                    Kategori = Kategori.AnaYemek,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\FirinTavukKanat.jpg"
                },
                new Besin
                {
                    ID = 54,
                    Ad = "Mevsim Salatası",
                    Aciklama = "Mevsim salatası yanında hindi dilimleri.",
                    PorsiyonBirimi = PorsiyonBirimi.Porsiyon,
                    Kalori = 120,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 8,
                    YagMiktari = 5,
                    OnayliMi = true,
                    Kategori = Kategori.Salata,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MevsimSalatasi.jpg"
                },
                new Besin
                {
                    ID = 55,
                    Ad = "Kumpir",
                    Aciklama = "Kumpir yanında garnitürlerle servis edilir.",
                    PorsiyonBirimi = PorsiyonBirimi.Porsiyon,
                    Kalori = 250,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 10,
                    YagMiktari = 12,
                    OnayliMi = true,
                    Kategori = Kategori.Fastfood,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\Kumpir.jpg"
                },
                new Besin
                {
                    ID = 56,
                    Ad = "Ton Balıklı Salata",
                    Aciklama = "Ton balıklı salata yanında zeytinyağlı sos.",
                    PorsiyonBirimi = PorsiyonBirimi.Porsiyon,
                    Kalori = 180,
                    KarbonhidratMiktari = 15,
                    ProteinMiktari = 20,
                    YagMiktari = 8,
                    OnayliMi = true,
                    Kategori = Kategori.Salata,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\TonBalikliSalata.jpg"
                },
                new Besin
                {
                    ID = 57,
                    Ad = "Muz ve Yulaf Ezmesi Smoothie",
                    Aciklama = "Muz ve yulaf ezmesi içeren smoothie.",
                    PorsiyonBirimi = PorsiyonBirimi.Gram,
                    Kalori = 150,
                    KarbonhidratMiktari = 30,
                    ProteinMiktari = 5,
                    YagMiktari = 2,
                    OnayliMi = true,
                    Kategori = Kategori.Aperatif,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\MuzYulafSmoothie.jpg"
                },
                new Besin
                {
                    ID = 58,
                    Ad = "Yoğurtlu Meyve Salatası",
                    Aciklama = "Yoğurtlu meyve salatası.",
                    PorsiyonBirimi = PorsiyonBirimi.Porsiyon,
                    Kalori = 100,
                    KarbonhidratMiktari = 20,
                    ProteinMiktari = 3,
                    YagMiktari = 1,
                    OnayliMi = true,
                    Kategori = Kategori.Salata,
                    Fotograf = "C:\\Users\\Harun\\Desktop\\BesinData-Resimler\\YogurluMeyveSalatasi.jpg"
                }
                ); 
        }
    }
}
