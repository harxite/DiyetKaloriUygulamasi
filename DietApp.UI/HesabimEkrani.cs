using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
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
    public partial class HesabimEkrani : Form
    {
        private int kullaniciID;
        Kullanici kullanici;
        KullaniciService kullaniciService;
        public HesabimEkrani()
        {
            InitializeComponent();
        }

        public HesabimEkrani(int kullaniciID)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            kullaniciService = new KullaniciService();
        }

        private void HesabimEkrani_Load(object sender, EventArgs e)
        {
            kullanici = kullaniciService.GetByUserId(kullaniciID);
            string adSoyad = $"{kullanici.Ad} {kullanici.Soyad}";
            lblAdSoyad.Text = adSoyad;
            lblYas.Text = kullanici.Yas.ToString();
            lblBoy.Text = kullanici.Boy.ToString();
            lblKilo.Text = kullanici.Kilo.ToString();
            lblHedefKilo.Text = kullanici.HedefKilo.ToString();
            lblAktiviteDuzeyi.Text = kullanici.AktiviteDuzeyi.ToString();
        }

        private void btnProfiliDuzenle_Click(object sender, EventArgs e)
        {
            ProfilEkrani profilEkrani = new ProfilEkrani(kullaniciID);
            profilEkrani.ShowDialog();
        }

        private void btnHesabiSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Hesabinizi gercekten silmek istiyor musunuz ?", "Hesabimi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                kullaniciService.Delete(kullanici);
                MessageBox.Show("Hesabiniz basarili bir sekilde silinmistir.");
                Application.Exit();
            }
        }
    }
}
