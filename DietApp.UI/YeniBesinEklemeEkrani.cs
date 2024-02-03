using AppDiet.BLL.Services;
using AppDiet.DAL.Context;
using AppDiet.DAL.Repositories;
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
    public partial class YeniBesinEklemeEkrani : Form
    {
        public YeniBesinEklemeEkrani()
        {
            InitializeComponent();
            btnSil.Enabled = false;
        }
        public YeniBesinEklemeEkrani(int BesinId)
        {
            InitializeComponent();
            Bs = new BesinService();
            btnYeniBesinEkle.Text = "Düzenle";
            btnSil.Enabled = true;
            Id = BesinId;
            BilgileriGetir();

        }

        private void BilgileriGetir()
        {
            Besin besin = Bs.GetBesinByID(Id);
            txtBesinAd.Text = besin.Ad;
            txtBesinAciklama.Text = besin.Aciklama;
            cmbKategori.SelectedItem = besin.Kategori;
            cmbBirim.SelectedItem = besin.PorsiyonBirimi;
            nudProteinMiktari.Value = (decimal)besin.ProteinMiktari;
            nudKarbonHMiktari.Value = (decimal)besin.KarbonhidratMiktari;
            nudYagMiktari.Value = (decimal)besin.YagMiktari;
            nudKaloriMiktari.Value = besin.Kalori;
            pbBesinFotograf.ImageLocation = besin.Fotograf;
        }

        BesinService Bs;
        string fotografYolu;
        int Id;

        private void YeniBesinEklemeEkrani_Load(object sender, EventArgs e)
        {

            Bs = new BesinService();
          
            ComboBoxiDoldur();
           
        }

        private void ComboBoxiDoldur()
        {
            foreach (Kategori kategori in Enum.GetValues(typeof(Kategori)))
            {
                cmbKategori.Items.Add(kategori);
            }
            foreach (PorsiyonBirimi porsiyon in Enum.GetValues(typeof(PorsiyonBirimi)))
            {
                cmbBirim.Items.Add(porsiyon);
            }
            cmbKategori.ValueMember = "Key";
            cmbKategori.DisplayMember = "Value";
            cmbBirim.ValueMember = "Key";
            cmbBirim.DisplayMember = "Value";
        }

        private void btnYeniBesinEkle_Click(object sender, EventArgs e)
        {
            if (btnYeniBesinEkle.Text == "EKLE")
            {
                if (string.IsNullOrEmpty(txtBesinAd.Text) && nudKaloriMiktari.Value == 0)
                {
                    MessageBox.Show("Lütfen yeni eklenecek isim için kalori miktarını ve adını giriniz.");
                    return;
                }
                Besin besin = new Besin();
                besin.Ad = txtBesinAd.Text;
                besin.Aciklama = txtBesinAciklama.Text;
                besin.Kategori = (Kategori)Enum.Parse(typeof(Kategori), cmbKategori.SelectedItem.ToString());
                besin.PorsiyonBirimi = (PorsiyonBirimi)Enum.Parse(typeof(PorsiyonBirimi), cmbBirim.SelectedItem.ToString());
                besin.OnayliMi = false;
                besin.ProteinMiktari = (double)nudProteinMiktari.Value;
                besin.KarbonhidratMiktari = (double)nudKarbonHMiktari.Value;
                besin.YagMiktari = (double)nudYagMiktari.Value;
                besin.Kalori = (int)nudKaloriMiktari.Value;
                besin.Fotograf = fotografYolu;
                Bs.YeniBesinekle(besin);
                this.Close();

            }
            if (btnYeniBesinEkle.Text == "Düzenle")
            {
                if (string.IsNullOrEmpty(txtBesinAd.Text) && nudKaloriMiktari.Value == 0)
                {
                    MessageBox.Show("Lütfen yeni eklenecek isim için kalori miktarını ve adını giriniz.");
                    return;
                }
                Besin besin = Bs.GetBesinByID(Id);
                besin.Ad = txtBesinAd.Text;
                besin.Aciklama = txtBesinAciklama.Text;
                besin.Kategori = (Kategori)Enum.Parse(typeof(Kategori), cmbKategori.SelectedItem.ToString());
                besin.PorsiyonBirimi = (PorsiyonBirimi)Enum.Parse(typeof(PorsiyonBirimi), cmbBirim.SelectedItem.ToString());
                besin.OnayliMi = false;
                besin.ProteinMiktari = (double)nudProteinMiktari.Value;
                besin.KarbonhidratMiktari = (double)nudKarbonHMiktari.Value;
                besin.YagMiktari = (double)nudYagMiktari.Value;
                besin.Kalori = (int)nudKaloriMiktari.Value;
                besin.Fotograf = fotografYolu;
                Bs.BesinGuncelle(besin);
                this.Close();
            }
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbBesinFotograf.ImageLocation = openFileDialog.FileName;
                fotografYolu = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Herhangi bir fotoğraf seçmediniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Besini silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Besin besin = Bs.GetBesinByID(Id);
                Bs.Delete(besin);


                MessageBox.Show("Besin silinmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (result == DialogResult.No)
            {

                MessageBox.Show("Besin silme işlemi iptal edilmiştir.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
