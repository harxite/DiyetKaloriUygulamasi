using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI
{
    public partial class AnalizEkrani : Form
    {
        int kullaniciID;
        KullaniciService kullaniciService;
        GunlukDetayService gunlukDetayService;
        OgunService ogunService;

        public AnalizEkrani()
        {
            InitializeComponent();
        }

        public AnalizEkrani(int kullaniciId)
        {
            InitializeComponent();
            kullaniciID = kullaniciId;
            ogunService = new OgunService();
            gunlukDetayService = new GunlukDetayService();
            kullaniciService = new KullaniciService();
        }

        private void AnalizEkrani_Load(object sender, EventArgs e)
        {
            rbGunSonuRpr.Checked = true;
            rbHaftalikRpr.Checked = true;
            GunSonuRaporunuGetir();
            HaftalikKiyasRaporunuGetir();
        }

        private void HaftalikKiyasRaporunuGetir()
        {
            lblHFTKah1.Text = gunlukDetayService.IDyeGoreKahvaltiOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTOgle1.Text = gunlukDetayService.IDyeGoreOgleYemegiOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTAks1.Text = gunlukDetayService.IDyeGoreAksamYemegiOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTAra1.Text = gunlukDetayService.IDyeGoreAraOgunOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTBtn1.Text = gunlukDetayService.IDyeGoreHaftalikOrtalamaKaloriGetir(kullaniciID).ToString("N1");

            lblHFTKah2.Text = gunlukDetayService.TumKullanicilarinKahvaltiHaftalikOrtalamaKaloriGetir().ToString("N1");
            lblHFTOgle2.Text = gunlukDetayService.TumKullanicilarinOgleYemegiHaftalikOrtalamaKaloriGetir().ToString("N1");
            lblHFTAks2.Text = gunlukDetayService.TumKullanicilarinAksamYemegiHaftalikOrtalamaKaloriGetir().ToString("N1");
            lblHFTAra2.Text = gunlukDetayService.TumKullanicilarinAraOgunHaftalikOrtalamaKaloriGetir().ToString("N1");
            lblHFTBtn2.Text = gunlukDetayService.TumKullanicilarinHaftalikOrtalamaKaloriGetir().ToString("N1");

            lblHFTAnaYemek1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.AnaYemek).ToString("N1");
            lblHFTKahvaltilik1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Kahvaltilik).ToString("N1");
            lblHFTAperatif1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Aperatif).ToString("N1");
            lblHFTSalata1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Salata).ToString("N1");
            lblHFTTatli1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Tatli).ToString("N1");
            lblHFTAtistirmalik1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Atistirmalik).ToString("N1");
            lblHFTIcecek1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Icecek).ToString("N1");
            lblHFTFastF1.Text = gunlukDetayService.IDyeGoreHaftalikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Fastfood).ToString("N1");

            lblHFTAnaYemek2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.AnaYemek).ToString("N1");
            lblHFTKahvaltilik2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Kahvaltilik).ToString("N1");
            lblHFTAperatif2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Aperatif).ToString("N1");
            lblHFTSalata2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Salata).ToString("N1");
            lblHFTTatli2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Tatli).ToString("N1");
            lblHFTAtistirmalik2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Atistirmalik).ToString("N1");
            lblHFTIcecek2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Icecek).ToString("N1");
            lblHFTFastF2.Text = gunlukDetayService.TumKullanicilarinHaftalikKategoriOrtalamaKaloriGetir(Kategori.Fastfood).ToString("N1");

        }

        private void AylikKiyasRaporunuGetir()
        {
            lblHFTKah1.Text = gunlukDetayService.IDyeGoreAylikKahvaltiOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTOgle1.Text = gunlukDetayService.IDyeGoreAylikOgleYemegiOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTAks1.Text = gunlukDetayService.IDyeGoreAylikAksamYemegiOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTAra1.Text = gunlukDetayService.IDyeGoreAylikAraOgunOrtalamaKaloriGetir(kullaniciID).ToString("N1");
            lblHFTBtn1.Text = gunlukDetayService.IDyeGoreAylikOrtalamaKaloriGetir(kullaniciID).ToString("N1");

            lblHFTKah2.Text = gunlukDetayService.TumKullanicilarinAylikKahvaltiOrtalamaKaloriGetir().ToString("N1");
            lblHFTOgle2.Text = gunlukDetayService.TumKullanicilarinAylikOgleYemegiOrtalamaKaloriGetir().ToString("N1");
            lblHFTAks2.Text = gunlukDetayService.TumKullanicilarinAylikAksamYemegiOrtalamaKaloriGetir().ToString("N1");
            lblHFTAra2.Text = gunlukDetayService.TumKullanicilarinAylikAraOgunOrtalamaKaloriGetir().ToString("N1");
            lblHFTBtn2.Text = gunlukDetayService.TumKullanicilarinAylikOrtalamaKaloriGetir().ToString();

            lblHFTAnaYemek1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.AnaYemek).ToString("N1");
            lblHFTKahvaltilik1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Kahvaltilik).ToString("N1");
            lblHFTAperatif1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Aperatif).ToString("N1");
            lblHFTSalata1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Salata).ToString("N1");
            lblHFTTatli1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Tatli).ToString("N1");
            lblHFTAtistirmalik1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Atistirmalik).ToString("N1");
            lblHFTIcecek1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Icecek).ToString("N1");
            lblHFTFastF1.Text = gunlukDetayService.IDyeGoreAylikKategoriOrtalamaKaloriGetir(kullaniciID, Kategori.Fastfood).ToString("N1");

            lblHFTAnaYemek2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.AnaYemek).ToString("N1");
            lblHFTKahvaltilik2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Kahvaltilik).ToString("N1");
            lblHFTAperatif2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Aperatif).ToString("N1");
            lblHFTSalata2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Salata).ToString("N1");
            lblHFTTatli2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Tatli).ToString("N1");
            lblHFTAtistirmalik2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Atistirmalik).ToString("N1");
            lblHFTIcecek2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Icecek).ToString("N1");
            lblHFTFastF2.Text = gunlukDetayService.TumKullanicilarinAylikKategoriOrtalamaKaloriGetir(Kategori.Fastfood).ToString("N1");

        }

        private void GunSonuRaporunuGetir()
        {
            GunlukDetay gunlukDetay = gunlukDetayService.GetTodayByUserId(kullaniciID);

            lblToplamKal.Text = gunlukDetay.AlinanToplamKalori.ToString("N1");
            lblToplamKarb.Text = gunlukDetay.AlinanToplamKarbonhidrat.ToString("N1") + " gr";
            lblToplamYag.Text = gunlukDetay.AlinanToplamYag.ToString("N1") + " gr";
            lblToplamPro.Text = gunlukDetay.AlinanToplamProtein.ToString("N1") + " gr";

            Kahvalti kahvalti = ogunService.IDyeGoreKahvaltiGetir((int)gunlukDetay.KahvaltiID);

            lblKahKal.Text = kahvalti.AlinanToplamKalori.ToString("N1");
            lblKahKarb.Text = kahvalti.AlinanToplamKarbonhidrat.ToString("N1") + " gr";
            lblKahYag.Text = kahvalti.AlinanToplamYag.ToString("N1") + "  gr";
            lblKahPro.Text = kahvalti.AlinanToplamProtein.ToString("N1") + " gr";

            OgleYemegi ogleYemegi = ogunService.IDyeGoreOgleYemegiGetir((int)gunlukDetay.OgleYemegiID);

            lblOgleKal.Text = ogleYemegi.AlinanToplamKalori.ToString("N1");
            lblOgleKarb.Text = ogleYemegi.AlinanToplamKarbonhidrat.ToString("N1") + " gr";
            lblOgleYag.Text = ogleYemegi.AlinanToplamYag.ToString("N1") + " gr";
            lblOglePro.Text = ogleYemegi.AlinanToplamProtein.ToString("N1") + "  gr";

            AksamYemegi aksamYemegi = ogunService.IDyeGoreAksamYemegiGetir((int)gunlukDetay.AksamYemegiID);

            lblAksamKal.Text = aksamYemegi.AlinanToplamKalori.ToString("N1");
            lblAksamKarb.Text = aksamYemegi.AlinanToplamKarbonhidrat.ToString("N1") + " gr";
            lblAksamYag.Text = aksamYemegi.AlinanToplamYag.ToString("N1") + " gr";
            lblAksamPro.Text = aksamYemegi.AlinanToplamProtein.ToString("N1") + "  gr";

            AraOgun araOgun = ogunService.IDyeGoreAraOgunGetir((int)gunlukDetay.AraOgunID);

            lblAraKal.Text = araOgun.AlinanToplamKalori.ToString("N1");
            lblAraKarb.Text = araOgun.AlinanToplamKarbonhidrat.ToString("N1") + " gr";
            lblAraYag.Text = araOgun.AlinanToplamYag.ToString("N1") + " gr";
            lblAraPro.Text = araOgun.AlinanToplamProtein.ToString("N1") + "  gr";
        }


        private void YemekCesidiRaporunuGetir()
        {
            List<string> kahvaltiEnCokYenenBesinler = gunlukDetayService.IDyeGoreKahvaltidaEnCokYenilenBesinler(kullaniciID);
            List<string> ogleEnCokYenenBesinler = gunlukDetayService.IDyeGoreOgleYemegindeEnCokYenilenBesinler(kullaniciID);
            List<string> aksamEnCokYenenBesinler = gunlukDetayService.IDyeGoreAksamYemegindeEnCokYenilenBesinler(kullaniciID);
            List<string> araEnCokYenenBesinler = gunlukDetayService.IDyeGoreAraOgundeEnCokYenilenBesinler(kullaniciID);
            List<string> toplamEnCokYenenBesinler = gunlukDetayService.IDyeGoreEnCokYenilenBesinler(kullaniciID);

            lblKahKal.Text = GetBesinAdi(kahvaltiEnCokYenenBesinler, 0);
            lblKahKarb.Text = GetBesinAdi(kahvaltiEnCokYenenBesinler, 1);
            lblKahYag.Text = GetBesinAdi(kahvaltiEnCokYenenBesinler, 2);
            lblKahPro.Text = GetBesinAdi(kahvaltiEnCokYenenBesinler, 3);

            lblOgleKal.Text = GetBesinAdi(ogleEnCokYenenBesinler, 0);
            lblOgleKarb.Text = GetBesinAdi(ogleEnCokYenenBesinler, 1);
            lblOgleYag.Text = GetBesinAdi(ogleEnCokYenenBesinler, 2);
            lblOglePro.Text = GetBesinAdi(ogleEnCokYenenBesinler, 3);

            lblAksamKal.Text = GetBesinAdi(aksamEnCokYenenBesinler, 0);
            lblAksamKarb.Text = GetBesinAdi(aksamEnCokYenenBesinler, 1);
            lblAksamYag.Text = GetBesinAdi(aksamEnCokYenenBesinler, 2);
            lblAksamPro.Text = GetBesinAdi(aksamEnCokYenenBesinler, 3);

            lblAraKal.Text = GetBesinAdi(araEnCokYenenBesinler, 0);
            lblAraKarb.Text = GetBesinAdi(araEnCokYenenBesinler, 1);
            lblAraYag.Text = GetBesinAdi(araEnCokYenenBesinler, 2);
            lblAraPro.Text = GetBesinAdi(araEnCokYenenBesinler, 3);

            lblToplamKal.Text = GetBesinAdi(toplamEnCokYenenBesinler, 0);
            lblToplamKarb.Text = GetBesinAdi(toplamEnCokYenenBesinler, 1);
            lblToplamYag.Text = GetBesinAdi(toplamEnCokYenenBesinler, 2);
            lblToplamPro.Text = GetBesinAdi(toplamEnCokYenenBesinler, 3);
        }

        private string GetBesinAdi(List<string> besinler, int index)
        {
            if (besinler != null && besinler.Count > index)
            {
                return (index + 1) + "- " + besinler[index];
            }
            else
            {
                return "";
            }
        }

        private void btnGosterGunYemek_Click(object sender, EventArgs e)
        {
            if (rbYemekCesidiRpr.Checked)
            {
                gbGunYemekRapor.Text = "Yemek Cesitleri Raporu";
                YemekCesidiRaporunuGetir();
                lblToplamKalText.Text = "En sevdiginiz yemeklerin\nlistesini sagdaki tablodan\ninceleyebilirsiniz.";
                lblToplamKarText.Hide();
                lblToplamYagText.Hide();
                lblToplamProText.Hide();
            }
            else
            {
                gbGunYemekRapor.Text = "Gun Sonu Raporu";
                GunSonuRaporunuGetir();
                lblToplamKalText.Text = "Toplam Kalori :";
                lblToplamKarText.Show();
                lblToplamYagText.Show();
                lblToplamProText.Show();
            }

        }

        private void btnGosterHaftaAy_Click(object sender, EventArgs e)
        {
            if (rbAylikRpr.Checked)
            {
                gbHaftaAyRapor.Text = "Aylik Kiyas Raporu";
                AylikKiyasRaporunuGetir();
            }
            else
            {
                gbHaftaAyRapor.Text = "Haftalik Kiyas Raporu";
                HaftalikKiyasRaporunuGetir();
            }
        }


    }
}
