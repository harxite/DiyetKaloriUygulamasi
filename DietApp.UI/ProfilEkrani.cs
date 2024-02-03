using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI
{
    public partial class ProfilEkrani : Form
    {
        private Kullanici kullanici;
        Kullanici kullanici1;
        int kullaniciID;
        KullaniciService kullaniciService;

        public ProfilEkrani()
        {
            InitializeComponent();
        }

        public ProfilEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            kullaniciService = new KullaniciService();
        }

        public ProfilEkrani(int kullaniciId)
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
            this.kullaniciID = kullaniciId;
            BilgileriDoldur();
            btnKayitOl.Text = "Guncelle";
        }
        private void ProfilEkrani_Load(object sender, EventArgs e)
        {
            radOrta.Checked = true;
        }
        private void BilgileriDoldur()
        {
            kullanici1 = kullaniciService.GetByUserId(kullaniciID);
            nudBoy.Value = kullanici1.Boy;
            nudKilo.Value = (decimal)kullanici1.Kilo;
            nudHedefKilo.Value = (decimal)kullanici1.HedefKilo;

            switch (kullanici1.AktiviteDuzeyi)
            {
                case AktiviteDuzeyi.Hareketsiz:
                    radHareketsiz.Checked = true;
                    break;
                case AktiviteDuzeyi.Hafif:
                    radHafif.Checked = true;
                    break;
                case AktiviteDuzeyi.Orta:
                    radOrta.Checked = true;
                    break;
                case AktiviteDuzeyi.Yuksek:
                    radYuksek.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            if (btnKayitOl.Text == "KAYIT OL")
            {
                string aktivite;

                kullanici.Boy = (int)nudBoy.Value;
                kullanici.Kilo = (double)nudKilo.Value;
                kullanici.HedefKilo = (double)nudHedefKilo.Value;
                kullanici.AktiviteDuzeyi = radHareketsiz.Checked ? AktiviteDuzeyi.Hareketsiz : radHafif.Checked ? AktiviteDuzeyi.Hafif : radOrta.Checked ? AktiviteDuzeyi.Orta : AktiviteDuzeyi.Yuksek;
                if (kullanici.Durum == Durum.Duzenlendi)
                    kullaniciService.Update(kullanici);
                else
                    kullaniciService.Add(kullanici);

                MessageBox.Show("Kayit Basarili!");

                GirisEkrani girisEkrani = new GirisEkrani();
                this.Hide();
                girisEkrani.ShowDialog();
                this.Show();
            }
            else
            {
                string aktivite;

                kullanici1.Boy = (int)nudBoy.Value;
                kullanici1.Kilo = (double)nudKilo.Value;
                kullanici1.HedefKilo = (double)nudHedefKilo.Value;
                kullanici1.AktiviteDuzeyi = radHareketsiz.Checked ? AktiviteDuzeyi.Hareketsiz : radHafif.Checked ? AktiviteDuzeyi.Hafif : radOrta.Checked ? AktiviteDuzeyi.Orta : AktiviteDuzeyi.Yuksek;
                kullaniciService.Update(kullanici1);
                MessageBox.Show("Guncelleme Basarili");
            }
        }

     
    }
}
