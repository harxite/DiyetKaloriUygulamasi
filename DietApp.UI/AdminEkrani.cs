using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietApp.UI
{
    public partial class AdminEkrani : Form
    {
        KullaniciService kullaniciService;
        BesinService besinService;
        public AdminEkrani()
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
            besinService = new BesinService();
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            List<Kullanici> kullanicilar = kullaniciService.StandartKullanicilariGetir();
            List<Besin> besinler = besinService.OnaysizBesinleriGetir();
            KullaniciListesiniDoldur(kullanicilar);
            BesinListesiniDoldur(besinler);
        }

        private void KullaniciListesiniDoldur(List<Kullanici> kullanicilar)
        {
            lvKullanicilar.Items.Clear();
            foreach (Kullanici kullanici in kullanicilar)
            {
                string aktiflik = kullanici.AktifMi ? "Aktif" : "Pasif";
                string[] datas = { kullanici.Ad, kullanici.Soyad, kullanici.Email, aktiflik };
                ListViewItem lvi = new ListViewItem(datas);
                lvi.Tag = kullanici.ID;

                lvKullanicilar.Items.Add(lvi);
            }

            int aktifKullaniciSayisi = kullanicilar.Count(k => k.AktifMi == true);
            int pasifKullaniciSayisi = kullanicilar.Count(k => k.AktifMi == false);

            lblToplamKullanici.Text = kullanicilar.Count.ToString();
            lblAktifSayisi.Text = aktifKullaniciSayisi.ToString();
            lblPasifSayisi.Text = pasifKullaniciSayisi.ToString();
        }

        private void BesinListesiniDoldur(List<Besin> besinler)
        {
            lvBesinler.Items.Clear();
            foreach (Besin besin in besinler)
            {
                string[] datas = { besin.Ad, besin.Kalori.ToString(), besin.KarbonhidratMiktari.ToString(), besin.ProteinMiktari.ToString(), besin.YagMiktari.ToString(), "Cift Tiklayin" };
                ListViewItem lvi = new ListViewItem(datas);
                lvi.Tag = besin.ID;

                lvBesinler.Items.Add(lvi);
            }

            lblToplamBesin.Text = besinler.Count.ToString();
        }

        private void btnAktifPasif_Click(object sender, EventArgs e)
        {
            if (lvKullanicilar.SelectedItems.Count > 0)
            {
                int kullaniciId = (int)lvKullanicilar.FocusedItem.Tag;
                kullaniciService.AktiflikDurumunuDegistir(kullaniciId);
                MessageBox.Show("Kullanici durumu degisti");

                List<Kullanici> kullanicilar = kullaniciService.StandartKullanicilariGetir();
                KullaniciListesiniDoldur(kullanicilar);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (lvBesinler.SelectedItems.Count > 0)
            {
                int besinId = (int)lvBesinler.FocusedItem.Tag;
                besinService.OnayDurumunuDegistir(besinId);
                MessageBox.Show("Secilen besin onaylandi");

                List<Besin> besinler = besinService.OnaysizBesinleriGetir();
                BesinListesiniDoldur(besinler);
            }
        }

        private void lvBesinler_DoubleClick(object sender, EventArgs e)
        {
            if (lvBesinler.SelectedItems.Count > 0)
            {
                int besinId = (int)lvBesinler.FocusedItem.Tag;
                Besin besin = besinService.GetBesinByID(besinId);
                BesinFotografiEkrani besinFotografiEkrani = new BesinFotografiEkrani(besin);
                besinFotografiEkrani.ShowDialog();
            }
        }
    }
}
