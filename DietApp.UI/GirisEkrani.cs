using AppDiet.BLL.Services;
using AppDiet.Domain.Entities;
using AppDiet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI
{
    public partial class GirisEkrani : Form
    {
        KullaniciService kullaniciService;
        public GirisEkrani()
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
        }
        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Butun bosluklari doldurunuz!");
                return;
            }

            Kullanici kullanici = kullaniciService.GetByEmail(txtEmail.Text);
            if (kullanici == null)
            {
                MessageBox.Show("E-mail adresiniz sisteme kayitli degil. Lutfen kayit olunuz!");
                return;
            }

            if (kullanici.Sifre != txtSifre.Text)
            {
                MessageBox.Show("Hatali sifre girdiniz!");
                return;
            }

            if (kullanici.Durum == Durum.Silindi)
            {
                DialogResult sonuc = MessageBox.Show("Boyle bir hesap bulunamadi!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!kullanici.AktifMi)
            {
                DialogResult sonuc = MessageBox.Show("Giris yapmak istediginiz hesap pasiftir, destek@dietapp.com ile iletişime geçiniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (kullanici.KullaniciTipi)
            {
                case KullaniciTipi.Admin:
                    AdminEkrani adminEkrani = new AdminEkrani();
                    this.Hide();
                    adminEkrani.ShowDialog();
                    this.Show();
                    return;

                case KullaniciTipi.Standart:
                    AnaEkran anaEkran = new AnaEkran(kullanici.ID);
                    this.Hide();
                    anaEkran.ShowDialog();
                    this.Show();
                    return;

                default:
                    return;
            }
        }

        private void cboxSifreGizleGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboxSifreGizleGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

    }
}
