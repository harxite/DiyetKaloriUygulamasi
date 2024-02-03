using AppDiet.DAL.Context;
using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.DAL.Repositories
{
    public class GunlukDetayRepository
    {
        AppDbContext dbContext;
        public GunlukDetayRepository()
        {
            dbContext = new AppDbContext();
        }
        public void Add(GunlukDetay gunlukDetay)
        {
            dbContext.GunlukDetaylar.Add(gunlukDetay);
            dbContext.SaveChanges();
        }

        public GunlukDetay GetTodayByUserId(int kullaniciId)
        {
            DateTime bugun = DateTime.Today;
            GunlukDetay gunlukDetay = dbContext.GunlukDetaylar.FirstOrDefault(x => x.KullaniciId == kullaniciId && x.OlusturulmaTarihi.Date == bugun);
            return gunlukDetay;
        }

        public GunlukDetay SecilenGuneGoreGetir(DateTime secilenGun, int kullaniciId)
        {
            GunlukDetay gunlukDetay = dbContext.GunlukDetaylar.FirstOrDefault(x => x.KullaniciId == kullaniciId && x.OlusturulmaTarihi.Date == secilenGun.Date);
            return gunlukDetay;
        }

        public double IDyeGoreHaftalikOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var gunlukDetaylar = dbContext.GunlukDetaylar
                .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .ToList(); 

            var ortalamaKalori = gunlukDetaylar
                .GroupBy(gd => gd.OlusturulmaTarihi.DayOfWeek)
                .Select(grp => new
                {
                    GunAdi = grp.Key,
                    OrtalamaKalori = grp.Average(g => g.AlinanToplamKalori)
                })
                .ToList();

            double toplamOrtalamaKalori = ortalamaKalori.Sum(item => item.OrtalamaKalori);

            return toplamOrtalamaKalori;
        }

        public double IDyeGoreKahvaltiOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var kahvaltiOrtalamaKalori = dbContext.GunlukDetaylar
                .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .Where(gd => gd.Kahvalti != null)
                .Select(gd => (double?)gd.Kahvalti.AlinanToplamKalori)
                .ToList()
                .DefaultIfEmpty(0)
                .Average();

            return (double)kahvaltiOrtalamaKalori;
        }

        public double IDyeGoreOgleYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var ogleOrtalamaKalori = dbContext.GunlukDetaylar
                    .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                    .Where(gd => gd.OgleYemegi != null)
                    .Select(gd => (double?)gd.OgleYemegi.AlinanToplamKalori)
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Average();

            return (double)ogleOrtalamaKalori;
        }

        public double IDyeGoreAksamYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var aksamOrtalamaKalori = dbContext.GunlukDetaylar
                    .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                    .Where(gd => gd.AksamYemegi != null)
                    .Select(gd => (double?)gd.AksamYemegi.AlinanToplamKalori)
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Average();

            return (double)aksamOrtalamaKalori;
        }

        public double IDyeGoreAraOgunOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var araOrtalamaKalori = dbContext.GunlukDetaylar
                    .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                    .Where(gd => gd.AraOgun != null)
                    .Select(gd => (double?)gd.AraOgun.AlinanToplamKalori)
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Average();

            return (double)araOrtalamaKalori;
        }

        public double TumKullanicilarinHaftalikOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .AsEnumerable(); // Bu noktadan sonraki işlemler bellekte çalışacak

            // Bellekteki veriler üzerinde devam ediyoruz
            var haftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .GroupBy(gd => gd.KullaniciId)
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    ToplamOrtalamaKalori = grp.Sum(g => g.AlinanToplamKalori) / grp.Count()
                })
                .Select(item => item.ToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return haftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinKahvaltiHaftalikOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .AsEnumerable() // Bu noktadan sonraki işlemler bellekte çalışacak
                .GroupBy(gd => gd.KullaniciId)
                .ToList();

            // Bellekteki veriler üzerinde devam ediyoruz
            var kahvaltiHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    KahvaltiToplamOrtalamaKalori = grp.Where(g => g.Kahvalti != null)
                        .Select(g => g.Kahvalti.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.KahvaltiToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return kahvaltiHaftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinOgleYemegiHaftalikOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .AsEnumerable() // Bu noktadan sonraki işlemler bellekte çalışacak
                .GroupBy(gd => gd.KullaniciId)
                .ToList();

            // Bellekteki veriler üzerinde devam ediyoruz
            var aksamYemegiHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    AksamYemegiToplamOrtalamaKalori = grp.Where(g => g.AksamYemegi != null)
                        .Select(g => g.AksamYemegi.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.AksamYemegiToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return aksamYemegiHaftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinAraOgunHaftalikOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .AsEnumerable(); // Bu noktadan sonraki işlemler bellekte çalışacak

            // Bellekteki veriler üzerinde devam ediyoruz
            var araOgunHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .GroupBy(gd => gd.KullaniciId)
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    AraOgunToplamOrtalamaKalori = grp.Where(g => g.AraOgun != null)
                        .Select(g => g.AraOgun.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.AraOgunToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return araOgunHaftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinAksamYemegiHaftalikOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= baslangicTarihi && gd.OlusturulmaTarihi <= bitisTarihi)
                .AsEnumerable(); // Bu noktadan sonraki işlemler bellekte çalışacak

            // Bellekteki veriler üzerinde devam ediyoruz
            var aksamYemegiHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .GroupBy(gd => gd.KullaniciId)
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    AksamYemegiToplamOrtalamaKalori = grp.Where(g => g.AksamYemegi != null)
                        .Select(g => g.AksamYemegi.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.AksamYemegiToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return aksamYemegiHaftalikToplamOrtalamaKaloriler;
        }

        public double IDyeGoreAylikOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            var aylikOrtalamaKaloriler = dbContext.GunlukDetaylar
                .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                .GroupBy(gd => gd.OlusturulmaTarihi.Day)
                .Select(grp => new
                {
                    Gun = grp.Key,
                    OrtalamaKalori = grp.Average(g => g.AlinanToplamKalori)
                })
                .ToList();

            double toplamOrtalamaKalori = aylikOrtalamaKaloriler.Average(item => item.OrtalamaKalori);

            return toplamOrtalamaKalori;
        }

        public double IDyeGoreAylikKahvaltiOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            var kahvaltiOrtalamaKalori = dbContext.GunlukDetaylar
                .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                .Where(gd => gd.Kahvalti != null)
                .Select(gd => (double?)gd.Kahvalti.AlinanToplamKalori)
                .ToList()
                .DefaultIfEmpty(0)
                .Average();

            return (double)kahvaltiOrtalamaKalori;
        }

        public double IDyeGoreAylikOgleYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            var ogleOrtalamaKalori = dbContext.GunlukDetaylar
                     .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                     .Where(gd => gd.OgleYemegi != null)
                     .Select(gd => (double?)gd.OgleYemegi.AlinanToplamKalori)
                     .ToList()
                     .DefaultIfEmpty(0)
                     .Average();

            return (double)ogleOrtalamaKalori;
        }
        public double IDyeGoreAylikAksamYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            var aksamOrtalamaKalori = dbContext.GunlukDetaylar
                    .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                    .Where(gd => gd.AksamYemegi != null)
                    .Select(gd => (double?)gd.AksamYemegi.AlinanToplamKalori)
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Average();

            return (double)aksamOrtalamaKalori;
        }

        public double IDyeGoreAylikAraOgunOrtalamaKaloriGetir(int kullaniciId)
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            var araOrtalamaKalori = dbContext.GunlukDetaylar
                    .Where(gd => gd.KullaniciId == kullaniciId && gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                    .Where(gd => gd.AraOgun != null)
                    .Select(gd => (double?)gd.AraOgun.AlinanToplamKalori)
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Average();

            return (double)araOrtalamaKalori;
        }

        public double TumKullanicilarinAylikOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinIlkGunu)
                .AsEnumerable(); // Bu noktadan sonraki işlemler bellekte çalışacak

            // Bellekteki veriler üzerinde devam ediyoruz
            var haftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .GroupBy(gd => gd.KullaniciId)
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    ToplamOrtalamaKalori = grp.Sum(g => g.AlinanToplamKalori) / grp.Count()
                })
                .Select(item => item.ToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return haftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinAylikKahvaltiOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                .AsEnumerable() // Bu noktadan sonraki işlemler bellekte çalışacak
                .GroupBy(gd => gd.KullaniciId)
                .ToList();

            // Bellekteki veriler üzerinde devam ediyoruz
            var kahvaltiHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    KahvaltiToplamOrtalamaKalori = grp.Where(g => g.Kahvalti != null)
                        .Select(g => g.Kahvalti.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.KahvaltiToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return kahvaltiHaftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinAylikOgleYemegiOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                .AsEnumerable() // Bu noktadan sonraki işlemler bellekte çalışacak
                .GroupBy(gd => gd.KullaniciId)
                .ToList();

            // Bellekteki veriler üzerinde devam ediyoruz
            var aksamYemegiHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    AksamYemegiToplamOrtalamaKalori = grp.Where(g => g.AksamYemegi != null)
                        .Select(g => g.AksamYemegi.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.AksamYemegiToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return aksamYemegiHaftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinAylikAksamYemegiOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                .AsEnumerable(); // Bu noktadan sonraki işlemler bellekte çalışacak

            // Bellekteki veriler üzerinde devam ediyoruz
            var aksamYemegiHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .GroupBy(gd => gd.KullaniciId)
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    AksamYemegiToplamOrtalamaKalori = grp.Where(g => g.AksamYemegi != null)
                        .Select(g => g.AksamYemegi.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.AksamYemegiToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return aksamYemegiHaftalikToplamOrtalamaKaloriler;
        }

        public double TumKullanicilarinAylikAraOgunOrtalamaKaloriGetir()
        {
            DateTime now = DateTime.Now;
            DateTime ayinIlkGunu = new DateTime(now.Year, now.Month, 1);
            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);

            // Veritabanından veri çekilip bellekte çalıştırılıyor
            var gunlukDetaylarList = dbContext.GunlukDetaylar
                .Where(gd => gd.OlusturulmaTarihi >= ayinIlkGunu && gd.OlusturulmaTarihi <= ayinSonGunu)
                .AsEnumerable(); // Bu noktadan sonraki işlemler bellekte çalışacak

            // Bellekteki veriler üzerinde devam ediyoruz
            var araOgunHaftalikToplamOrtalamaKaloriler = gunlukDetaylarList
                .GroupBy(gd => gd.KullaniciId)
                .Select(grp => new
                {
                    KullaniciId = grp.Key,
                    AraOgunToplamOrtalamaKalori = grp.Where(g => g.AraOgun != null)
                        .Select(g => g.AraOgun.AlinanToplamKalori)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .Select(item => item.AraOgunToplamOrtalamaKalori)
                .DefaultIfEmpty(0)
                .Average();

            return araOgunHaftalikToplamOrtalamaKaloriler;
        }

        public double IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(int kullaniciId, Kategori kategori)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var ortalamaKaloriler = dbContext.GunlukDetaylar
                .Where(g => g.KullaniciId == kullaniciId && g.OlusturulmaTarihi >= baslangicTarihi && g.OlusturulmaTarihi <= bitisTarihi)
                .SelectMany(g => g.Kahvalti.Besinler
                    .Concat(g.OgleYemegi.Besinler)
                    .Concat(g.AksamYemegi.Besinler)
                    .Concat(g.AraOgun.Besinler))
                .Where(b => b.Kategori == kategori)
                .GroupBy(b => b.Kategori)
                .Select(g => new
                {
                    Kategori = g.Key,
                    ortalamaKalori = g.Average(besin => besin.Kalori)
                })
                .FirstOrDefault(); // Eğer bir kategoriye ait besin yoksa null dönecek

            if (ortalamaKaloriler != null)
            {
                return ortalamaKaloriler.ortalamaKalori;
            }
            else
            {
                return 0.0; // Eğer bir kategoriye ait besin yoksa, ortalama kaloriyi sıfır olarak döndür
            }
        }
        public double TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori kategori)
        {
            DateTime now = DateTime.Now;
            DateTime baslangicTarihi = now.AddDays(-6);
            DateTime bitisTarihi = now;

            var toplamKaloriler = dbContext.GunlukDetaylar
                .Where(g => g.OlusturulmaTarihi >= baslangicTarihi && g.OlusturulmaTarihi <= bitisTarihi)
                .SelectMany(g => g.Kahvalti.Besinler
                    .Concat(g.OgleYemegi.Besinler)
                    .Concat(g.AksamYemegi.Besinler)
                    .Concat(g.AraOgun.Besinler))
                .Where(b => b.Kategori == kategori)
                .Sum(besin => besin.Kalori);

            int toplamKullaniciSayisi = dbContext.Kullanicilar.Count(); // Tüm kullanıcı sayısını al

            if (toplamKullaniciSayisi > 0)
            {
                double ortalamaKalori = toplamKaloriler / toplamKullaniciSayisi; // Toplam kalorileri kullanıcı sayısına bölerek ortalama kaloriyi bul
                return ortalamaKalori;
            }
            else
            {
                return 0.0; // Eğer hiç kullanıcı yoksa, ortalama kaloriyi sıfır olarak döndür
            }
        }


        public double IDyeGoreAylikKategoriOrtalamaKaloriGetir(int kullaniciId, Kategori kategori)
        {
            DateTime ayBaslangic = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ayBitis = ayBaslangic.AddMonths(1).AddDays(-1);

            var ortalamaKaloriler = dbContext.GunlukDetaylar
               .Where(g => g.KullaniciId == kullaniciId && g.OlusturulmaTarihi >= ayBaslangic && g.OlusturulmaTarihi <= ayBitis)
               .SelectMany(g => g.Kahvalti.Besinler
                   .Concat(g.OgleYemegi.Besinler)
                   .Concat(g.AksamYemegi.Besinler)
                   .Concat(g.AraOgun.Besinler))
               .Where(b => b.Kategori == kategori)
               .GroupBy(b => b.Kategori)
               .Select(g => new
               {
                   Kategori = g.Key,
                   ortalamaKalori = g.Average(besin => besin.Kalori)
               })
               .FirstOrDefault(); // Eğer bir kategoriye ait besin yoksa null dönecek

            if (ortalamaKaloriler != null)
            {
                return ortalamaKaloriler.ortalamaKalori;
            }
            else
            {
                return 0.0; // Eğer bir kategoriye ait besin yoksa, ortalama kaloriyi sıfır olarak döndür
            }
        }

        public double TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori kategori)
        {
            DateTime ayBaslangic = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ayBitis = ayBaslangic.AddMonths(1).AddDays(-1);

            var toplamKaloriler = dbContext.GunlukDetaylar
                .Where(g => g.OlusturulmaTarihi >= ayBaslangic && g.OlusturulmaTarihi <= ayBitis)
                .SelectMany(g => g.Kahvalti.Besinler
                    .Concat(g.OgleYemegi.Besinler)
                    .Concat(g.AksamYemegi.Besinler)
                    .Concat(g.AraOgun.Besinler))
                .Where(b => b.Kategori == kategori)
                .Sum(besin => besin.Kalori);

            int toplamKullaniciSayisi = dbContext.Kullanicilar.Count(); // Tüm kullanıcı sayısını al

            if (toplamKullaniciSayisi > 0)
            {
                double ortalamaKalori = toplamKaloriler / toplamKullaniciSayisi; // Toplam kalorileri kullanıcı sayısına bölerek ortalama kaloriyi bul
                return ortalamaKalori;
            }
            else
            {
                return 0.0; // Eğer hiç kullanıcı yoksa, ortalama kaloriyi sıfır olarak döndür
            }
        }

        public List<string> IDyeGoreKahvaltidaEnCokYenilenBesinler(int kullaniciId)
        {
            var enCokYenilenBesinler = dbContext.GunlukDetaylar
                .Where(g => g.KullaniciId == kullaniciId)
                .SelectMany(g => g.Kahvalti.Besinler)
                .GroupBy(b => b.Ad)
                .OrderByDescending(g => g.Sum(b => b.Miktar))
                .Take(4) 
                .Select(g => g.Key) 
                .ToList();

            return enCokYenilenBesinler;
        }

        public List<string> IDyeGoreOgleYemegindeEnCokYenilenBesinler(int kullaniciId)
        {
            var enCokYenilenBesinler = dbContext.GunlukDetaylar
                .Where(g => g.KullaniciId == kullaniciId)
                .SelectMany(g => g.OgleYemegi.Besinler)
                .GroupBy(b => b.Ad)
                .OrderByDescending(g => g.Sum(b => b.Miktar)) 
                .Take(4)
                .Select(g => g.Key) 
                .ToList();

            return enCokYenilenBesinler;
        }

        public List<string> IDyeGoreAksamYemegindeEnCokYenilenBesinler(int kullaniciId)
        {
            var enCokYenilenBesinler = dbContext.GunlukDetaylar
                .Where(g => g.KullaniciId == kullaniciId)
                .SelectMany(g => g.AksamYemegi.Besinler)
                .GroupBy(b => b.Ad)
                .OrderByDescending(g => g.Sum(b => b.Miktar))
                .Take(4)
                .Select(g => g.Key)
                .ToList();

            return enCokYenilenBesinler;
        }

        public List<string> IDyeGoreAraOgundeEnCokYenilenBesinler(int kullaniciId)
        {
            var enCokYenilenBesinler = dbContext.GunlukDetaylar
                .Where(g => g.KullaniciId == kullaniciId)
                .SelectMany(g => g.AraOgun.Besinler)
                .GroupBy(b => b.Ad)
                .OrderByDescending(g => g.Sum(b => b.Miktar))
                .Take(4)
                .Select(g => g.Key)
                .ToList();

            return enCokYenilenBesinler;
        }
        public List<string> IDyeGoreEnCokYenilenBesinler(int kullaniciId)
        {
            var enCokYenilenBesinler = dbContext.GunlukDetaylar
                .Where(g => g.KullaniciId == kullaniciId)
                .SelectMany(g => g.Kahvalti.Besinler
                    .Concat(g.OgleYemegi.Besinler)
                    .Concat(g.AksamYemegi.Besinler)
                    .Concat(g.AraOgun.Besinler))
                .GroupBy(b => b.Ad)
                .OrderByDescending(g => g.Sum(b => b.Miktar)) 
                .Take(4) 
                .Select(g => g.Key) 
                .ToList();

            return enCokYenilenBesinler;
        }

        public void Update(GunlukDetay gunlukDetay)
        {
            dbContext.GunlukDetaylar.Update(gunlukDetay);
            dbContext.SaveChanges();
        }
    }
}
