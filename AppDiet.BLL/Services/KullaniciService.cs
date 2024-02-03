using AppDiet.DAL.Repositories;
using AppDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.BLL.Services
{
    public class KullaniciService
    {
        KullaniciRepository kullaniciRepository;
        public KullaniciService()
        {
            kullaniciRepository = new KullaniciRepository();    
        }

        public Kullanici GetByUserId(int kullaniciId)
        {
            return kullaniciRepository.GetByID(kullaniciId);
        }
        public Kullanici GetByEmail(string email)
        {
            return kullaniciRepository.GetByEmail(email);
        }

        public void Add(Kullanici kullanici)
        {
            kullanici.Durum = Domain.Enums.Durum.Eklendi;
            kullaniciRepository.Add(kullanici);
        }
        public bool CheckEmail(string email)
        {
            Kullanici kullanici = GetByEmail(email);
            if (kullanici is null)
                return false;
            else
                return true;
        }

        public bool DurumuSilindiMi(string email)
        {
            Kullanici kullanici = GetByEmail(email);
            if (kullanici.Durum == Domain.Enums.Durum.Silindi)
                return true;
            else
                return false;
                
        }
        public void Delete(Kullanici kullanici)
        {
            kullanici.Durum = Domain.Enums.Durum.Silindi;
            kullanici.SilinmeTarihi = DateTime.Now;
            kullanici.AktifMi = false;
            kullaniciRepository.Update(kullanici);
        }
        public void Update(Kullanici kullanici)
        {
            kullanici.Durum = Domain.Enums.Durum.Duzenlendi;
            kullanici.DegistirilmeTarihi = DateTime.Now;
            kullaniciRepository.Update(kullanici);
        }

        public List<Kullanici> StandartKullanicilariGetir()
        {
          return kullaniciRepository.StandartKullanicilariGetir();
        }

        public void AktiflikDurumunuDegistir(int kullaniciId)
        {
            Kullanici kullanici = kullaniciRepository.GetByID(kullaniciId);
            if (kullanici.AktifMi)
            {
                kullanici.AktifMi = false;
            }
            else
                kullanici.AktifMi = true;
            Update(kullanici);
        }
    }
}
