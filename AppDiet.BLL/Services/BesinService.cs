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
    public class BesinService
    {
        BesinRepository besinRepository;
        public BesinService()
        {
            besinRepository = new BesinRepository();
        }


        public List<Besin> KahvaltiBesinleriniGetir(int kahvaltiId)
        {
            return besinRepository.KahvaltiBesinleriniGetir(kahvaltiId);
        }
        public List<Besin> OgleYemegiBesinleriniGetir(int ogleYemegiId)
        {
            return besinRepository.OgleYemegiBesinleriniGetir(ogleYemegiId);
        }
        public List<Besin> AksamYemegiBesinleriniGetir(int aksamYemegiId)
        {
            return besinRepository.AksamYemegiBesinleriniGetir(aksamYemegiId);
        }
        public List<Besin> AraOgunBesinleriniGetir(int araOgunId)
        {
            return besinRepository.AraOgunBesinleriniGetir(araOgunId);
        }

        public Besin GetByID(int besinId)
        {
            return besinRepository.GetByID(besinId);
        }

        public void Delete(Besin besin)
        {
            besin.Durum = Domain.Enums.Durum.Silindi;
            besin.SilinmeTarihi = DateTime.Now;
            besinRepository.Update(besin);
        }

        public List<Besin> OnaysizBesinlerdenAramaYap(string arananKelime)
        {
            List<Besin> list = besinRepository.OnaysizBesinlerdenAramaYap(arananKelime);
            return list;
        }
        public void Update(Besin besin)
        {
            besin.Durum = Domain.Enums.Durum.Duzenlendi;
            besin.DegistirilmeTarihi = DateTime.Now;
            besinRepository.Update(besin);
        }

        public List<Besin> OnaysizBesinleriGetir()
        {
            return besinRepository.OnaysizBesinleriGetir();
        }

        public void OnayDurumunuDegistir(int besinId)
        {
            Besin besin = besinRepository.GetByID(besinId);
            besin.OnayliMi = true;
            besin.Durum = 0;
            Update(besin);
        }

        public Besin GetBesinByID(int id)
        {
            Besin besin = besinRepository.GetBesinByID(id);
            return besin;

        }

        public void YeniBesinekle(Besin besin)
        {
            besinRepository.Add(besin);
        }

        public List<Besin> TumBesinleriGetir()
        {
            List<Besin> Besinler = besinRepository.TumBesinleriGetir();
            return Besinler;
        }

        public Besin OgunIcinYeniBesinOlustur(Besin besin)
        {
            Besin Besin = besinRepository.OgunYeniIcinBesinOlusur(besin);
            return besin;
        }

        public Besin OgununBesininiBul(OgunBase ogun)
        {
            Besin Besin = besinRepository.OgununBesininiBul(ogun);
            return Besin;
        }

        public List<Besin> BesinBul(string text)
        {
            List<Besin> ArananBesinler = besinRepository.BesinBul(text);
            return ArananBesinler;
        }

        public bool OnayliMi(int id)
        {
            bool cevap = besinRepository.onayliMi(id);
            return cevap;
        }

        public void BesinGuncelle(Besin besin, string ad, decimal kalori)
        {
            besinRepository.Update(besin, ad, kalori);
        }
        public void BesinGuncelle(Besin besin)
        {
            besinRepository.Update(besin);
        }

        public List<Besin> OnayliBesinleriGetir()
        {
            List<Besin> OnayliBesinler = besinRepository.OnayliBesinleriGetir();
            return OnayliBesinler;
        }
    }
}
