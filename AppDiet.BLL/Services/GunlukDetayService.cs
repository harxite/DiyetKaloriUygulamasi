using AppDiet.DAL.Repositories;
using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.BLL.Services
{
    public class GunlukDetayService
    {
        GunlukDetayRepository gunlukDetayRepository;

        public GunlukDetayService()
        {
            gunlukDetayRepository = new GunlukDetayRepository();    
        }

        public void Add(GunlukDetay gunlukDetay)
        {
            gunlukDetayRepository.Add(gunlukDetay);
        }
      

        public GunlukDetay GetTodayByUserId(int kullaniciId)
        {
            return gunlukDetayRepository.GetTodayByUserId(kullaniciId);
        }

        public GunlukDetay SecilenGuneGoreGetir(DateTime secilenGun,int kullaniciId)
        {
            return gunlukDetayRepository.SecilenGuneGoreGetir(secilenGun, kullaniciId);
        }

        public double IDyeGoreHaftalikOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreHaftalikOrtalamaKaloriGetir(kullaniciId);
        }

        public double IDyeGoreKahvaltiOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreKahvaltiOrtalamaKaloriGetir(kullaniciId);
        }

        public double IDyeGoreOgleYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreOgleYemegiOrtalamaKaloriGetir(kullaniciId);
        }

        public double IDyeGoreAksamYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAksamYemegiOrtalamaKaloriGetir(kullaniciId);
        }

        public double IDyeGoreAraOgunOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAraOgunOrtalamaKaloriGetir(kullaniciId);
        }

        public double TumKullanicilarinHaftalikOrtalamaKaloriGetir()
        {
           return gunlukDetayRepository.TumKullanicilarinHaftalikOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinKahvaltiHaftalikOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinKahvaltiHaftalikOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinOgleYemegiHaftalikOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinOgleYemegiHaftalikOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinAksamYemegiHaftalikOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAksamYemegiHaftalikOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinAraOgunHaftalikOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAraOgunHaftalikOrtalamaKaloriGetir();
        }

        public double IDyeGoreAylikOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAylikOrtalamaKaloriGetir( kullaniciId);
        }

        public double IDyeGoreAylikKahvaltiOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAylikKahvaltiOrtalamaKaloriGetir(kullaniciId);
        }

        public double IDyeGoreAylikOgleYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAylikOgleYemegiOrtalamaKaloriGetir(kullaniciId);
        }
        public double IDyeGoreAylikAksamYemegiOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAylikAksamYemegiOrtalamaKaloriGetir(kullaniciId);
        }

        public double IDyeGoreAylikAraOgunOrtalamaKaloriGetir(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAylikAraOgunOrtalamaKaloriGetir( kullaniciId);
        }

        public double TumKullanicilarinAylikOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAylikOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinAylikKahvaltiOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAylikKahvaltiOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinAylikOgleYemegiOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAylikOgleYemegiOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinAylikAksamYemegiOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAylikAksamYemegiOrtalamaKaloriGetir();
        }

        public double TumKullanicilarinAylikAraOgunOrtalamaKaloriGetir()
        {
            return gunlukDetayRepository.TumKullanicilarinAylikAraOgunOrtalamaKaloriGetir();
        }

        public double IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(int kullaniciId, Kategori kategori)
        {
            return gunlukDetayRepository.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciId, kategori);
        }
        public double TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori kategori)
        {
            return gunlukDetayRepository.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir( kategori);
        }


        public double IDyeGoreAylikKategoriOrtalamaKaloriGetir(int kullaniciId, Kategori kategori)
        {
            return gunlukDetayRepository.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciId, kategori);
        }

        public double TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori kategori)
        {
            return gunlukDetayRepository.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(kategori);
        }

        public List<string> IDyeGoreKahvaltidaEnCokYenilenBesinler(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreKahvaltidaEnCokYenilenBesinler(kullaniciId);
        }

        public List<string> IDyeGoreOgleYemegindeEnCokYenilenBesinler(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreOgleYemegindeEnCokYenilenBesinler(kullaniciId);
        }

        public List<string> IDyeGoreAksamYemegindeEnCokYenilenBesinler(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAksamYemegindeEnCokYenilenBesinler(kullaniciId);
        }

        public List<string> IDyeGoreAraOgundeEnCokYenilenBesinler(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreAraOgundeEnCokYenilenBesinler(kullaniciId);
        }
        public List<string> IDyeGoreEnCokYenilenBesinler(int kullaniciId)
        {
            return gunlukDetayRepository.IDyeGoreEnCokYenilenBesinler(kullaniciId);
        }

        public void Update(GunlukDetay gunlukDetay)
        {
            gunlukDetayRepository.Update(gunlukDetay);
        }
    }
}
