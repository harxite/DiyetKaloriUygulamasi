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
    public class KullaniciRepository
    {
        AppDbContext dbContext;
        public KullaniciRepository()
        {
            dbContext = new AppDbContext();
        }

        public Kullanici GetByID(int kullaniciId)
        {
            Kullanici kullanici = dbContext.Kullanicilar.Find(kullaniciId);
            return kullanici;
        }
        public Kullanici GetByEmail(string email)
        {
            Kullanici kullanici = dbContext.Kullanicilar.FirstOrDefault(x => x.Email == email);
            return kullanici;
        }
        public void Add(Kullanici kullanici)
        {
            dbContext.Kullanicilar.Add(kullanici);
            dbContext.SaveChanges();
        }

        public void Update(Kullanici kullanici)
        {
            dbContext.Kullanicilar.Update(kullanici);
            dbContext.SaveChanges();
        }

        public List<Kullanici> StandartKullanicilariGetir()
        {
            List<Kullanici> kullanicilar = dbContext.Kullanicilar.Where(x => x.KullaniciTipi == Domain.Enums.KullaniciTipi.Standart && x.Durum != Domain.Enums.Durum.Silindi).ToList();
            return kullanicilar;
        }
    }
}
