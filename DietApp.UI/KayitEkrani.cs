using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using Microsoft.Extensions.Logging;
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
    public partial class KayitEkrani : Form
    {
        KullaniciService kullaniciService;
        public KayitEkrani()
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
        }
        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            radErkek.Checked = true;
            txtSifre.PasswordChar = '*';
            txtSifreTekrar.PasswordChar = '*';
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;

            if (sifre.Length < 6)
            {
                lblSifreSeviyesi.Text = "En az 6 haneli sifre giriniz!";
                lblSifreSeviyesi.ForeColor = Color.Red;
            }

            else if (sifre.Length >= 6)
            {
                bool ozelKarakter = sifre.Any(c => !char.IsLetterOrDigit(c));
                bool digit = sifre.Any(char.IsDigit);
                if (ozelKarakter && digit)
                {
                    lblSifreSeviyesi.Text = "Guclu";
                    lblSifreSeviyesi.ForeColor = Color.Green;
                }
                else if (ozelKarakter || digit)
                {
                    lblSifreSeviyesi.Text = "Orta";
                    lblSifreSeviyesi.ForeColor = Color.Blue;
                }
                else
                {
                    lblSifreSeviyesi.Text = "Zayif";
                    lblSifreSeviyesi.ForeColor = Color.OrangeRed;
                }
            }
        }

        private void btnIlerle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtSifreTekrar.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Bütün bilgileri doldurunuz!");
                return;
            }

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Sifreler eslesmiyor!");
                return;
            }

            bool kullaniciKontrol = kullaniciService.CheckEmail(txtEmail.Text);
            if (kullaniciKontrol)
            {
                bool silindiMi = kullaniciService.DurumuSilindiMi(txtEmail.Text);
                if (silindiMi)
                {
                    Kullanici kullanici1 = kullaniciService.GetByEmail(txtEmail.Text);
                    kullanici1.Durum = Durum.Duzenlendi;
                    kullanici1.AktifMi = true;
                    kullanici1.Email = txtEmail.Text;
                    kullanici1.Sifre = txtSifre.Text;
                    kullanici1.Ad = txtAd.Text;
                    kullanici1.Soyad = txtSoyad.Text;
                    kullanici1.Yas = (int)nudYas.Value;
                    kullanici1.Cinsiyet = radErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                    kullaniciService.Update(kullanici1);
                    ProfilEkrani profilEkrani = new ProfilEkrani(kullanici1);
                    this.Hide();
                    profilEkrani.ShowDialog();
                    this.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Mail adresi sisteme kayitlidir, baska mail adresi giriniz!");
                    return;
                }
            }
            else
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Email = txtEmail.Text;
                kullanici.Sifre = txtSifre.Text;
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Yas = (int)nudYas.Value;
                kullanici.Cinsiyet = radErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                ProfilEkrani profilEkrani = new ProfilEkrani(kullanici);
                this.Hide();
                profilEkrani.ShowDialog();
                this.Show();
            }
        }

        private void cboxSifreGizleGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxSifreGizleGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtSifreTekrar.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtSifreTekrar.PasswordChar = '*';
            }
        }
    }
}
