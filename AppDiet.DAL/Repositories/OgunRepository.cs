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
    public class OgunRepository
    {
        AppDbContext dbContext;
        public OgunRepository()
        {
            dbContext = new AppDbContext();
        }

        public void KahvaltiEkle(Kahvalti kahvalti)
        {
            dbContext.Kahvaltilar.Add(kahvalti);
            dbContext.SaveChanges();
        }
        public void OgleYemegiEkle(OgleYemegi ogleYemegi)
        {
            dbContext.OgleYemekleri.Add(ogleYemegi);
            dbContext.SaveChanges();
        }
        public void AksamYemegiEkle(AksamYemegi aksamYemegi)
        {
            dbContext.AksamYemekleri.Add(aksamYemegi);
            dbContext.SaveChanges();
        }
        public void AraOgunEkle(AraOgun araOgun)
        {
            dbContext.AraOgunler.Add(araOgun);
            dbContext.SaveChanges();
        }

        public Kahvalti IDyeGoreKahvaltiGetir(int gunlukDetayKahvaltiId)
        {
            Kahvalti kahvalti = dbContext.Kahvaltilar.FirstOrDefault(x => x.ID == gunlukDetayKahvaltiId);
            return kahvalti;
        }
        public OgleYemegi IDyeGoreOgleYemegiGetir(int gunlukDetayOgleYemegiId)
        {
            OgleYemegi ogleYemegi = dbContext.OgleYemekleri.FirstOrDefault(x => x.ID == gunlukDetayOgleYemegiId);
            return ogleYemegi;
        }
        public AksamYemegi IDyeGoreAksamYemegiGetir(int gunlukDetayAksamYemegiId)
        {
            AksamYemegi aksamYemegi = dbContext.AksamYemekleri.FirstOrDefault(x => x.ID == gunlukDetayAksamYemegiId);
            return aksamYemegi;
        }
        public AraOgun IDyeGoreAraOgunGetir(int gunlukDetayAraOgunId)
        {
            AraOgun araOgun = dbContext.AraOgunler.FirstOrDefault(x => x.ID == gunlukDetayAraOgunId);
            return araOgun;
        }
        public void OguneGoreBesinEkle(Besin besin, OgunBase ogun)
        {
            if (ogun is Kahvalti kahvalti)
            {
                Kahvalti kahvaltiEntity = dbContext.Kahvaltilar.Include(x => x.Besinler).FirstOrDefault(x => x.ID == kahvalti.ID);

                if (kahvaltiEntity != null)
                {
                    besin.KahvaltiID = ogun.ID;
                    dbContext.Besinler.Add(besin);
                    dbContext.SaveChanges();
                }
            }
            if (ogun is AraOgun araOgun)
            {
                AraOgun araOgunEntity = dbContext.AraOgunler.Include(x => x.Besinler).FirstOrDefault(x => x.ID == araOgun.ID);

                if (araOgunEntity != null)
                {
                    dbContext.Besinler.Add(besin);
                    dbContext.SaveChanges();
                }
            }
            if (ogun is OgleYemegi ogleYemegi)
            {
                OgleYemegi ogleYemegiEntity = dbContext.OgleYemekleri.Include(x => x.Besinler).FirstOrDefault(x => x.ID == ogleYemegi.ID);

                if (ogleYemegiEntity != null)
                {
                    dbContext.Besinler.Add(besin);
                    dbContext.SaveChanges();
                }
            }
            if (ogun is AksamYemegi aksamYemegi)
            {
                AksamYemegi aksamYemegiEntity = dbContext.AksamYemekleri.Include(x => x.Besinler).FirstOrDefault(x => x.ID == aksamYemegi.ID);

                if (aksamYemegiEntity != null)
                {
                    dbContext.Besinler.Add(besin);
                    dbContext.SaveChanges();
                }
            }
        }

        public string OgunAdiBul(OgunBase ogun)
        {
            if (ogun is Kahvalti)
                return "Kahvaltı";
            if (ogun is AraOgun)
                return "Ara Öğün";
            if (ogun is OgleYemegi)
                return "Öğle Yemeği";
            else
                return "Akşam Yemeği";
        }

        public void Update(OgunBase ogun)
        {
            dbContext.Update(ogun);
            dbContext.SaveChanges();
        }
    }
}
