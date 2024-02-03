using AppDiet.DAL.Context;
using AppDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.DAL.Repositories
{
    public class BesinRepository
    {
        AppDbContext dbContext;
        public BesinRepository()
        {
            dbContext = new AppDbContext();
        }

        public List<Besin> KahvaltiBesinleriniGetir(int kahvaltiId)
        {
            List<Besin> besinler = dbContext.Kahvaltilar
                                   .Where(k => k.ID == kahvaltiId)
                                   .SelectMany(k => k.Besinler)
                                   .Where(b => b.Durum != Domain.Enums.Durum.Silindi)
                                   .ToList();
            return besinler;
        }

        public List<Besin> OgleYemegiBesinleriniGetir(int ogleYemegiId)
        {
            List<Besin> besinler = dbContext.OgleYemekleri
                                     .Where(k => k.ID == ogleYemegiId)
                                     .SelectMany(k => k.Besinler)
                                     .Where(b => b.Durum != Domain.Enums.Durum.Silindi)
                                     .ToList();

            return besinler;
        }
        public List<Besin> AksamYemegiBesinleriniGetir(int aksamYemegiId)
        {
            List<Besin> besinler = dbContext.AksamYemekleri
                                     .Where(k => k.ID == aksamYemegiId)
                                     .SelectMany(k => k.Besinler)
                                     .Where(b => b.Durum != Domain.Enums.Durum.Silindi)
                                     .ToList();

            return besinler;
        }
        public List<Besin> AraOgunBesinleriniGetir(int araOgunId)
        {
            List<Besin> besinler = dbContext.AraOgunler
                                     .Where(k => k.ID == araOgunId)
                                     .SelectMany(k => k.Besinler)
                                     .Where(b => b.Durum != Domain.Enums.Durum.Silindi)
                                     .ToList();

            return besinler;
        }

        public Besin GetByID(int besinId)
        {
            Besin besin = dbContext.Besinler.Find(besinId);
            return besin;
        }

        public void Update(Besin besin)
        {
            dbContext.Besinler.Update(besin);
            dbContext.SaveChanges();
        }

        public List<Besin> OnaysizBesinlerdenAramaYap(string arananKelime)
        {
            List<Besin> OnaysizBesinler = OnaysizBesinleriGetir() ?? new List<Besin>();
            List<Besin> OnaysizBesinAramalari = OnaysizBesinler.Where(b => b.Ad.Contains(arananKelime)).ToList() ?? new List<Besin>();
            return OnaysizBesinAramalari;
        }
        public List<Besin> OnaysizBesinleriGetir()
        {
            List<Besin> besinler = dbContext.Besinler.Where(x => x.OnayliMi == false).ToList();
            return besinler;
        }

        public void Add(Besin besin)
        {
            dbContext.Besinler.Add(besin);
            dbContext.SaveChanges();
        }

        public void Update(Besin besin, string ad, decimal kalori)
        {
            besin.OnayliMi = false;
            besin.Ad = ad;
            besin.Kalori = (int)kalori;
            dbContext.Besinler.Update(besin);
            dbContext.SaveChanges();
        }

        public void Remove(Besin besin)
        {
            dbContext.Besinler.Remove(besin);
            dbContext.SaveChanges();
        }

        public Besin GetBesinByID(int id)
        {
            Besin besin = dbContext.Besinler.FirstOrDefault(x => x.ID == id);
            return besin;
        }

        public List<Besin> TumBesinleriGetir()
        {
            List<Besin> Besinler = dbContext.Besinler.ToList();
            return Besinler;
        }

        public Besin OgunYeniIcinBesinOlusur(Besin besin)
        {
            Besin Besin1 = new Besin();
            Besin1.Ad = besin.Ad;
            Besin1.Durum = besin.Durum;
            Besin1.ProteinMiktari = besin.ProteinMiktari;
            Besin1.KarbonhidratMiktari = besin.KarbonhidratMiktari;
            Besin1.YagMiktari = besin.YagMiktari;
            Besin1.OnayliMi = true;
            Besin1.Aciklama = besin.Aciklama;
            Besin1.Fotograf = besin.Fotograf;
            Besin1.Kalori = besin.Kalori;
            return Besin1;
        }

        public Besin OgununBesininiBul(OgunBase ogun)
        {
            Besin sonBesin = new Besin(); 
            if (ogun is Kahvalti)
            {
                sonBesin = dbContext.Kahvaltilar
               .Where(o => o.ID == ogun.ID)
               .SelectMany(o => o.Besinler)
               .OrderByDescending(b => b.OlusturulmaTarihi)
               .FirstOrDefault();

            }

            if (ogun is OgleYemegi)
            {
                sonBesin = dbContext.OgleYemekleri
               .Where(o => o.ID == ogun.ID)
               .SelectMany(o => o.Besinler)
               .OrderByDescending(b => b.OlusturulmaTarihi)
               .FirstOrDefault();

            }

            if (ogun is AksamYemegi)
            {
                sonBesin = dbContext.AksamYemekleri
               .Where(o => o.ID == ogun.ID)
               .SelectMany(o => o.Besinler)
               .OrderByDescending(b => b.OlusturulmaTarihi)
               .FirstOrDefault();

            }

            if (ogun is AraOgun)
            {
                sonBesin = dbContext.AraOgunler
               .Where(o => o.ID == ogun.ID)
               .SelectMany(o => o.Besinler)
               .OrderByDescending(b => b.OlusturulmaTarihi)
               .FirstOrDefault();

            }
            return sonBesin;
        }

        public List<Besin> BesinBul(string text)
        {
            List<Besin> ArananBesinler = dbContext.Besinler.Where(b => b.Ad.Contains(text)).ToList();
            return ArananBesinler;
        }

        public bool onayliMi(int id)
        {
            Besin besin = dbContext.Besinler.FirstOrDefault(b => b.ID == id);
            if (besin == null)
                return false;
            else
                return true;
        }

        public List<Besin> OnayliBesinleriGetir()
        {
            List<Besin> OnayliBesinler = dbContext.Besinler.Where(x => x.OnayliMi == true && x.Durum == 0).ToList();
            return OnayliBesinler;
        }
    }
}
