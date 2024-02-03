using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
using Microsoft.Win32.SafeHandles;
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
    public partial class AnaEkran : Form
    {
        KullaniciService kullaniciService;
        GunlukDetayService gunlukDetayService;
        OgunService ogunService;
        BesinService besinService;
        Kullanici kullanici;
        GunlukDetay gunlukDetay;
        GunlukDetay gunlukDetay1;
        Kahvalti kahvalti;
        OgleYemegi ogleYemegi;
        AksamYemegi aksamYemegi;
        AraOgun araOgun;
        int kullaniciID;

        public AnaEkran()
        {
            InitializeComponent();
        }
        public AnaEkran(int kullaniciId)
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
            gunlukDetayService = new GunlukDetayService();
            ogunService = new OgunService();
            besinService = new BesinService();
            kullaniciID = kullaniciId;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            gunlukDetay = gunlukDetayService.GetTodayByUserId(kullaniciID);
            kullanici = kullaniciService.GetByUserId(kullaniciID);

            if (gunlukDetay != null)
            {
                EkranaDatalariGetir(gunlukDetay);
            }
            else
            {
                gunlukDetay1 = new GunlukDetay();
                gunlukDetay1.KullaniciId = kullaniciID;

                kahvalti = new Kahvalti();
                ogunService.KahvaltiEkle(kahvalti);
                gunlukDetay1.KahvaltiID = kahvalti.ID;

                ogleYemegi = new OgleYemegi();
                ogunService.OgleYemegiEkle(ogleYemegi);
                gunlukDetay1.OgleYemegiID = ogleYemegi.ID;

                aksamYemegi = new AksamYemegi();
                ogunService.AksamYemegiEkle(aksamYemegi);
                gunlukDetay1.AksamYemegiID = aksamYemegi.ID;

                araOgun = new AraOgun();
                ogunService.AraOgunEkle(araOgun);
                gunlukDetay1.AraOgunID = araOgun.ID;

                double kaloriIhtiyaci = GunlukKaloriIhtiyaciHesapla(kullanici);
                gunlukDetay1.GunlukKaloriIhtiyaci = (int)kaloriIhtiyaci;

                lblKaloriIhtiyaci.Text = kaloriIhtiyaci.ToString();

                gunlukDetayService.Add(gunlukDetay1);

            }

            KahvaltiSeciliDegilkenButonlariAktifEt();
            OgleSeciliDegilkenButonlariAktifEt();
            AksamSeciliDegilkenButonlariAktifEt();
            AraSeciliDegilkenButonlariAktifEt();

            SecilileriKaldir();

        }

        private void EkranaDatalariGetir(GunlukDetay gunlukDetay)
        {
            KahvaltiDatalariniDoldur(gunlukDetay);
            OgleYemegiDatalariniDoldur(gunlukDetay);
            AksamYemegiDatalariniDoldur(gunlukDetay);
            AraOgunDatalariniDoldur(gunlukDetay);


            lblKaloriIhtiyaci.Text = gunlukDetay.GunlukKaloriIhtiyaci.ToString();

            gunlukDetay.AlinanToplamKalori = kahvalti.AlinanToplamKalori + ogleYemegi.AlinanToplamKalori + aksamYemegi.AlinanToplamKalori + araOgun.AlinanToplamKalori;

            gunlukDetay.AlinanToplamKarbonhidrat = kahvalti.AlinanToplamKarbonhidrat + ogleYemegi.AlinanToplamKarbonhidrat + aksamYemegi.AlinanToplamKarbonhidrat + araOgun.AlinanToplamKarbonhidrat;

            gunlukDetay.AlinanToplamProtein = kahvalti.AlinanToplamProtein + ogleYemegi.AlinanToplamProtein + aksamYemegi.AlinanToplamProtein + araOgun.AlinanToplamProtein;

            gunlukDetay.AlinanToplamYag = kahvalti.AlinanToplamYag + ogleYemegi.AlinanToplamYag + aksamYemegi.AlinanToplamYag + araOgun.AlinanToplamYag;


            lblToplamKalori.Text = gunlukDetay.AlinanToplamKalori.ToString();
            lblToplamKarbonhidrat.Text = gunlukDetay.AlinanToplamKarbonhidrat.ToString() + " gr";
            lblToplamProtein.Text = gunlukDetay.AlinanToplamProtein.ToString() + " gr";
            lblToplamYag.Text = gunlukDetay.AlinanToplamYag.ToString() + " gr";

            gunlukDetayService.Update(gunlukDetay);
            SecilileriKaldir();

        }


        private void AraOgunDatalariniDoldur(GunlukDetay gunlukDetay)
        {
            List<Besin> araOgunBesinList = new List<Besin>();
            araOgunBesinList = besinService.AraOgunBesinleriniGetir((int)gunlukDetay.AraOgunID);
            araOgun = ogunService.IDyeGoreAraOgunGetir((int)gunlukDetay.AraOgunID);

            lbAraOgun.DisplayMember = "Ad";
            lbAraOgun.ValueMember = "ID";
            lbAraOgun.DataSource = araOgunBesinList;

            if (araOgunBesinList.Count > 0)
            {
                araOgun.AlinanToplamKalori = OgundekiToplamKaloriyiHesapla(araOgunBesinList);
                araOgun.AlinanToplamProtein = OgundekiToplamProteiniHesapla(araOgunBesinList);
                araOgun.AlinanToplamYag = OgundekiToplamYagiHesapla(araOgunBesinList);
                araOgun.AlinanToplamKarbonhidrat = OgundekiToplamKarbonhidratiHesapla(araOgunBesinList);
            }

            lblAraToplamK.Text = araOgun.AlinanToplamKalori.ToString();

            ogunService.Update(araOgun);
        }

        private void AksamYemegiDatalariniDoldur(GunlukDetay gunlukDetay)
        {
            List<Besin> aksamBesinList = new List<Besin>();
            aksamBesinList = besinService.AksamYemegiBesinleriniGetir((int)gunlukDetay.AksamYemegiID);
            aksamYemegi = ogunService.IDyeGoreAksamYemegiGetir((int)gunlukDetay.AksamYemegiID);

            lbAksamYemegi.DisplayMember = "Ad";
            lbAksamYemegi.ValueMember = "ID";
            lbAksamYemegi.DataSource = aksamBesinList;

            if (aksamBesinList.Count > 0)
            {
                aksamYemegi.AlinanToplamKalori = OgundekiToplamKaloriyiHesapla(aksamBesinList);
                aksamYemegi.AlinanToplamProtein = OgundekiToplamProteiniHesapla(aksamBesinList);
                aksamYemegi.AlinanToplamYag = OgundekiToplamYagiHesapla(aksamBesinList);
                aksamYemegi.AlinanToplamKarbonhidrat = OgundekiToplamKarbonhidratiHesapla(aksamBesinList);
            }

            lblAksamToplamK.Text = aksamYemegi.AlinanToplamKalori.ToString();
            ogunService.Update(aksamYemegi);

        }

        private void OgleYemegiDatalariniDoldur(GunlukDetay gunlukDetay)
        {
            List<Besin> ogleBesinList = new List<Besin>();
            ogleBesinList = besinService.OgleYemegiBesinleriniGetir((int)gunlukDetay.OgleYemegiID);
            ogleYemegi = ogunService.IDyeGoreOgleYemegiGetir((int)gunlukDetay.OgleYemegiID);

            lbOgleYemegi.DisplayMember = "Ad";
            lbOgleYemegi.ValueMember = "ID";
            lbOgleYemegi.DataSource = ogleBesinList;

            if (ogleBesinList.Count > 0)
            {
                ogleYemegi.AlinanToplamKalori = OgundekiToplamKaloriyiHesapla(ogleBesinList);
                ogleYemegi.AlinanToplamProtein = OgundekiToplamProteiniHesapla(ogleBesinList);
                ogleYemegi.AlinanToplamYag = OgundekiToplamYagiHesapla(ogleBesinList);
                ogleYemegi.AlinanToplamKarbonhidrat = OgundekiToplamKarbonhidratiHesapla(ogleBesinList);
            }

            lblOgleToplamK.Text = ogleYemegi.AlinanToplamKalori.ToString();
            ogunService.Update(ogleYemegi);

        }

        private void KahvaltiDatalariniDoldur(GunlukDetay gunlukDetay)
        {
            List<Besin> kahvaltiBesinList = new List<Besin>();
            kahvaltiBesinList = besinService.KahvaltiBesinleriniGetir((int)gunlukDetay.KahvaltiID);
            kahvalti = ogunService.IDyeGoreKahvaltiGetir((int)gunlukDetay.KahvaltiID);

            lbKahvalti.DisplayMember = "Ad";
            lbKahvalti.ValueMember = "ID";
            lbKahvalti.DataSource = kahvaltiBesinList;

            if (kahvaltiBesinList.Count > 0)
            {
                kahvalti.AlinanToplamKalori = OgundekiToplamKaloriyiHesapla(kahvaltiBesinList);
                kahvalti.AlinanToplamProtein = OgundekiToplamProteiniHesapla(kahvaltiBesinList);
                kahvalti.AlinanToplamYag = OgundekiToplamYagiHesapla(kahvaltiBesinList);
                kahvalti.AlinanToplamKarbonhidrat = OgundekiToplamKarbonhidratiHesapla(kahvaltiBesinList);
            }

            lblKahvaltiToplamK.Text = kahvalti.AlinanToplamKalori.ToString();
            ogunService.Update(kahvalti);

        }

        private double OgundekiToplamKarbonhidratiHesapla(List<Besin> besinList)
        {
            double toplamKarbonhidrat = 0;
            foreach (Besin besin in besinList)
            {
                toplamKarbonhidrat += (double)(besin.KarbonhidratMiktari);
            }
            return toplamKarbonhidrat;
        }
        private double OgundekiToplamYagiHesapla(List<Besin> besinList)
        {
            double toplamYag = 0;
            foreach (Besin besin in besinList)
            {
                toplamYag += (double)(besin.YagMiktari);
            }
            return toplamYag;
        }

        private double OgundekiToplamProteiniHesapla(List<Besin> besinList)
        {
            double toplamProtein = 0;
            foreach (Besin besin in besinList)
            {
                toplamProtein += (double)besin.ProteinMiktari;
            }
            return toplamProtein;
        }

        private int OgundekiToplamKaloriyiHesapla(List<Besin> besinList)
        {
            int toplamKalori = 0;
            foreach (Besin besin in besinList)
            {
                toplamKalori += besin.Kalori;
            }
            return toplamKalori;
        }

        private void btnDuzenleKahvalti_Click(object sender, EventArgs e)
        {
            if (lbKahvalti.SelectedIndex > -1)
            {
                int besinId = (int)lbKahvalti.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                BesinDuzenlemeFormunuAc(besin, kahvalti);
            }
        }

        private void btnDuzenleOgle_Click(object sender, EventArgs e)
        {
            if (lbOgleYemegi.SelectedIndex > -1)
            {
                int besinId = (int)lbOgleYemegi.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                BesinDuzenlemeFormunuAc(besin, ogleYemegi);
            }
        }

        private void btnDuzenleAksam_Click(object sender, EventArgs e)
        {
            if (lbAksamYemegi.SelectedIndex > -1)
            {
                int besinId = (int)lbAksamYemegi.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                BesinDuzenlemeFormunuAc(besin, aksamYemegi);
            }
        }

        private void btnDuzenleAraOgun_Click(object sender, EventArgs e)
        {
            if (lbAraOgun.SelectedIndex > -1)
            {
                int besinId = (int)lbAraOgun.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                BesinDuzenlemeFormunuAc(besin, araOgun);
            }
        }

        private void btnSilKahvalti_Click(object sender, EventArgs e)
        {
            if (lbKahvalti.SelectedIndex > -1)
            {
                int besinId = (int)lbKahvalti.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                besinService.Delete(besin);
            }
            EkranaDatalariGetir(gunlukDetay);
        }

        private void btnSilOgle_Click(object sender, EventArgs e)
        {
            if (lbOgleYemegi.SelectedIndex > -1)
            {
                int besinId = (int)lbOgleYemegi.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                besinService.Delete(besin);
            }
            EkranaDatalariGetir(gunlukDetay);

        }

        private void btnSilAksam_Click(object sender, EventArgs e)
        {
            if (lbAksamYemegi.SelectedIndex > -1)
            {
                int besinId = (int)lbAksamYemegi.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                besinService.Delete(besin);
            }
            EkranaDatalariGetir(gunlukDetay);

        }

        private void btnSilAraOgun_Click(object sender, EventArgs e)
        {
            if (lbAraOgun.SelectedIndex > -1)
            {
                int besinId = (int)lbAraOgun.SelectedValue;
                Besin besin = besinService.GetByID(besinId);

                besinService.Delete(besin);
            }
            EkranaDatalariGetir(gunlukDetay);

        }

        private double GunlukKaloriIhtiyaciHesapla(Kullanici kullanici)
        {
            double kaloriIhtiyaci = 0;
            double aktiviteDuzeyi = 0;

            switch (kullanici.AktiviteDuzeyi)
            {
                case AppDiet.Domain.Enums.AktiviteDuzeyi.Hareketsiz:
                    aktiviteDuzeyi = 1.2;
                    break;
                case AppDiet.Domain.Enums.AktiviteDuzeyi.Hafif:
                    aktiviteDuzeyi = 1.375;
                    break;
                case AppDiet.Domain.Enums.AktiviteDuzeyi.Orta:
                    aktiviteDuzeyi = 1.55;
                    break;
                case AppDiet.Domain.Enums.AktiviteDuzeyi.Yuksek:
                    aktiviteDuzeyi = 1.725;
                    break;
                default:
                    break;
            }


            if (kullanici.Cinsiyet == AppDiet.Domain.Enums.Cinsiyet.Kadin)
            {
                kaloriIhtiyaci = ((10 * kullanici.Kilo) + (6.25 * kullanici.Boy) - (5 * kullanici.Yas - 161)) * aktiviteDuzeyi;
            }
            else
            {
                kaloriIhtiyaci = ((10 * kullanici.Kilo) + (6.25 * kullanici.Boy) - (5 * kullanici.Yas + 5)) * aktiviteDuzeyi;
            }

            return kaloriIhtiyaci;
        }

        private void btnEkleKahvalti_Click(object sender, EventArgs e)
        {
            Kahvalti kahvalti1;
            if (gunlukDetay1 == null)
            {
                kahvalti1 = ogunService.IDyeGoreKahvaltiGetir((int)gunlukDetay.KahvaltiID);
            }
            else
                kahvalti1 = ogunService.IDyeGoreKahvaltiGetir((int)gunlukDetay1.KahvaltiID);

            if (kahvalti1 == null)
            {
                BesinEklemeFormunuAc(kahvalti, kullaniciID);
                return;
            }
            else
                BesinEklemeFormunuAc(kahvalti1, kullaniciID);
        }

        private void btnEkleOgle_Click(object sender, EventArgs e)
        {
            OgleYemegi ogleYemegi1;

            if (gunlukDetay1 == null)
            {
                ogleYemegi1 = ogunService.IDyeGoreOgleYemegiGetir((int)gunlukDetay.OgleYemegiID);
            }
            else
                ogleYemegi1 = ogunService.IDyeGoreOgleYemegiGetir((int)gunlukDetay1.OgleYemegiID);
            if (ogleYemegi1 == null)
            {
                BesinEklemeFormunuAc(ogleYemegi, kullaniciID);
                return;
            }
            BesinEklemeFormunuAc(ogleYemegi1, kullaniciID);
        }

        private void btnEkleAksam_Click(object sender, EventArgs e)
        {
            AksamYemegi aksamYemegi1;

            if (gunlukDetay1 == null)
            {
                aksamYemegi1 = ogunService.IDyeGoreAksamYemegiGetir((int)gunlukDetay.AksamYemegiID);
            }
            else
                aksamYemegi1 = ogunService.IDyeGoreAksamYemegiGetir((int)gunlukDetay1.AksamYemegiID);

            if (aksamYemegi1 == null)
            {
                BesinEklemeFormunuAc(aksamYemegi, kullaniciID);
                return;
            }
            BesinEklemeFormunuAc(aksamYemegi1, kullaniciID);
        }

        private void btnEkleAraOgun_Click(object sender, EventArgs e)
        {
            AraOgun araOgun1;

            if (gunlukDetay1 == null)
            {
                araOgun1 = ogunService.IDyeGoreAraOgunGetir((int)gunlukDetay.AraOgunID);
            }
            else
                araOgun1 = ogunService.IDyeGoreAraOgunGetir((int)gunlukDetay1.AraOgunID);

            if (araOgun1 == null)
            {
                BesinEklemeFormunuAc(araOgun, kullaniciID);
                return;
            }
            BesinEklemeFormunuAc(araOgun1, kullaniciID);
        }

        private void BesinEklemeFormunuAc(OgunBase ogun, int kullaniciId)
        {
            this.Close();
            OgunOlusturmaEkrani ogunOlusturmaEkrani = new OgunOlusturmaEkrani(ogun, kullaniciID);
            ogunOlusturmaEkrani.ShowDialog();

        }

        private void BesinDuzenlemeFormunuAc(Besin besin, OgunBase ogun)
        {
            BesinEklemeEkrani besinEklemeEkrani = new BesinEklemeEkrani(besin, ogun);
            besinEklemeEkrani.ShowDialog();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            AnalizEkrani analizEkrani = new AnalizEkrani(kullaniciID);
            analizEkrani.ShowDialog();
        }

        private void btnSecilenGunuGoster_Click(object sender, EventArgs e)
        {
            DateTime secilenGun = dtpGununTarihi.Value;
            GunlukDetay gunlukDetay = gunlukDetayService.SecilenGuneGoreGetir(secilenGun, kullaniciID);
            if (gunlukDetay != null)
                EkranaDatalariGetir(gunlukDetay);
            else
                MessageBox.Show("Sectiginiz gune ait herhangi bir veri girisiniz bulunmamaktadir.");
        }

        private void btnHesabim_Click(object sender, EventArgs e)
        {
            HesabimEkrani hesabimEkrani = new HesabimEkrani(kullaniciID);
            hesabimEkrani.Show();
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lbKahvalti_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbKahvalti.IndexFromPoint(e.Location);

            if (index == -1)
            {
                lbKahvalti.ClearSelected();
                KahvaltiSeciliDegilkenButonlariAktifEt();
            }
            else
            {
                KahvaltiSeciliykenButonlariAktifEt();
                lbOgleYemegi.ClearSelected();
                OgleSeciliDegilkenButonlariAktifEt();
                lbAksamYemegi.ClearSelected();
                AksamSeciliDegilkenButonlariAktifEt();
                lbAraOgun.ClearSelected();
                AraSeciliDegilkenButonlariAktifEt();

            }
        }

        private void lbOgleYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbOgleYemegi.IndexFromPoint(e.Location);

            if (index == -1)
            {
                lbOgleYemegi.ClearSelected();
                OgleSeciliDegilkenButonlariAktifEt();
            }
            else
            {
                OgleSeciliykenButonlariAktifEt();
                lbKahvalti.ClearSelected();
                KahvaltiSeciliDegilkenButonlariAktifEt();
                lbAksamYemegi.ClearSelected();
                AksamSeciliDegilkenButonlariAktifEt();
                lbAraOgun.ClearSelected();
                AraSeciliDegilkenButonlariAktifEt();
            }
        }

        private void lbAksamYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbAksamYemegi.IndexFromPoint(e.Location);

            if (index == -1)
            {
                lbAksamYemegi.ClearSelected();
                AksamSeciliDegilkenButonlariAktifEt();
            }
            else
            {
                AksamSeciliykenButonlariAktifEt();
                lbKahvalti.ClearSelected();
                KahvaltiSeciliDegilkenButonlariAktifEt();
                lbOgleYemegi.ClearSelected();
                OgleSeciliDegilkenButonlariAktifEt();
                lbAraOgun.ClearSelected();
                AraSeciliDegilkenButonlariAktifEt();
            }
        }

        private void lbAraOgun_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbAraOgun.IndexFromPoint(e.Location);

            if (index == -1)
            {
                lbAraOgun.ClearSelected();
                AraSeciliDegilkenButonlariAktifEt();
            }
            else
            {
                AraSeciliykenButonlariAktifEt();
                lbKahvalti.ClearSelected();
                KahvaltiSeciliDegilkenButonlariAktifEt();
                lbOgleYemegi.ClearSelected();
                OgleSeciliDegilkenButonlariAktifEt();
                lbAksamYemegi.ClearSelected();
                AksamSeciliDegilkenButonlariAktifEt();
            }
        }

        private void KahvaltiSeciliykenButonlariAktifEt()
        {
            btnEkleKahvalti.Enabled = false;
            btnDuzenleKahvalti.Enabled = true;
            btnSilKahvalti.Enabled = true;
        }

        private void OgleSeciliykenButonlariAktifEt()
        {
            btnEkleOgle.Enabled = false;
            btnDuzenleOgle.Enabled = true;
            btnSilOgle.Enabled = true;
        }
        private void AksamSeciliykenButonlariAktifEt()
        {
            btnEkleAksam.Enabled = false;
            btnDuzenleAksam.Enabled = true;
            btnSilAksam.Enabled = true;
        }
        private void AraSeciliykenButonlariAktifEt()
        {
            btnEkleAraOgun.Enabled = false;
            btnDuzenleAraOgun.Enabled = true;
            btnSilAraOgun.Enabled = true;
        }
        private void KahvaltiSeciliDegilkenButonlariAktifEt()
        {
            btnEkleKahvalti.Enabled = true;
            btnDuzenleKahvalti.Enabled = false;
            btnSilKahvalti.Enabled = false;
        }
        private void OgleSeciliDegilkenButonlariAktifEt()
        {
            btnEkleOgle.Enabled = true;
            btnDuzenleOgle.Enabled = false;
            btnSilOgle.Enabled = false;
        }
        private void AksamSeciliDegilkenButonlariAktifEt()
        {
            btnEkleAksam.Enabled = true;
            btnDuzenleAksam.Enabled = false;
            btnSilAksam.Enabled = false;
        }
        private void AraSeciliDegilkenButonlariAktifEt()
        {
            btnEkleAraOgun.Enabled = true;
            btnDuzenleAraOgun.Enabled = false;
            btnSilAraOgun.Enabled = false;
        }
        private void SecilileriKaldir()
        {
            lbKahvalti.SelectedIndex = -1;
            lbOgleYemegi.SelectedIndex = -1;
            lbAksamYemegi.SelectedIndex = -1;
            lbAraOgun.SelectedIndex = -1;
        }

    }
}
