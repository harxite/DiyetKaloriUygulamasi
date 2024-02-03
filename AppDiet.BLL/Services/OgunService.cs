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
    public class OgunService
    {
        OgunRepository ogunRepository;
        public OgunService()
        {
            ogunRepository = new OgunRepository();
        }

        public void KahvaltiEkle(Kahvalti kahvalti)
        {
            ogunRepository.KahvaltiEkle(kahvalti);
        }
        public void OgleYemegiEkle(OgleYemegi ogleYemegi)
        {
            ogunRepository.OgleYemegiEkle(ogleYemegi);

        }
        public void AksamYemegiEkle(AksamYemegi aksamYemegi)
        {
            ogunRepository.AksamYemegiEkle(aksamYemegi);

        }
        public void AraOgunEkle(AraOgun araOgun)
        {
            ogunRepository.AraOgunEkle(araOgun);

        }
        public Kahvalti IDyeGoreKahvaltiGetir(int gunlukDetayKahvaltiId)
        {
            return ogunRepository.IDyeGoreKahvaltiGetir(gunlukDetayKahvaltiId);
        }
        public OgleYemegi IDyeGoreOgleYemegiGetir(int gunlukDetayOgleYemegiId)
        {
            return ogunRepository.IDyeGoreOgleYemegiGetir(gunlukDetayOgleYemegiId);
        }
        public AksamYemegi IDyeGoreAksamYemegiGetir(int gunlukDetayAksamYemegiId)
        {
            return ogunRepository.IDyeGoreAksamYemegiGetir(gunlukDetayAksamYemegiId);
        }
        public AraOgun IDyeGoreAraOgunGetir(int gunlukDetayAraOgunId)
        {
            return ogunRepository.IDyeGoreAraOgunGetir(gunlukDetayAraOgunId);
        }

        public void OguneGoreBesinEkle(Besin besin, OgunBase ogun)
        {
            ogunRepository.OguneGoreBesinEkle(besin,ogun);
        }

        public string OgunAdiBul(OgunBase ogun)
        {
            string HangiOgun = ogunRepository.OgunAdiBul(ogun);
            return HangiOgun;
        }

        public void Update(OgunBase ogun)
        {
            ogunRepository.Update(ogun);
        }
    }
}
