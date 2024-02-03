using AppDiet.BLL.Services;
using AppDiet.DAL.Context;
using AppDiet.DAL.Repositories;
using AppDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DietApp.UI
{
    public partial class OgunOlusturmaEkrani : Form
    {
        public OgunOlusturmaEkrani()
        {
            InitializeComponent();
        }

        public OgunOlusturmaEkrani(OgunBase ogun, int kullaniciId)
        {
            InitializeComponent();
            OContext = new OgunService();
            lblOgunAdi2.Text = OContext.OgunAdiBul(ogun);
            if (lblOgunAdi2.Text == null)
                lblOgunAdi2.Text = "ogunadı gelmedi";
            Ogun = ogun;
            kullaniciID = kullaniciId;
        }

        public OgunOlusturmaEkrani(Besin besin)
        {
            InitializeComponent();
            Besin = besin;
        }
        int kullaniciID;
        GunlukDetayService GContext;
        OgunService OContext;
        BesinService BContext;
        int Id;
        OgunBase Ogun;
        Besin Besin;
        List<Besin> SeciliBesinler;
        ListViewItem lstBesinItem;

        private void OgunOlusturmaEkrani_Load(object sender, EventArgs e)
        {
            BContext = new BesinService();
            SeciliBesinler = new List<Besin>();

            List<Besin> OnayliBesinler = BContext.OnayliBesinleriGetir();

            foreach (Besin besin in OnayliBesinler)
            {
                string[] BesinBilgiler = { besin.Ad, besin.Kalori.ToString(), besin.YagMiktari.ToString(), besin.ProteinMiktari.ToString(), besin.KarbonhidratMiktari.ToString() };
                ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
                lstBesinItem.Tag = besin;
                lstvBesinler.Items.Add(lstBesinItem);
            }

            List<Besin> OnaysizBesinler = BContext.OnaysizBesinleriGetir() ?? new List<Besin>();
            if (OnaysizBesinler.Count != 0)
            {
                foreach (Besin besin in OnaysizBesinler)
                {
                    string[] BesinBilgiler = { besin.Ad, besin.Kalori.ToString(), besin.YagMiktari.ToString(), besin.ProteinMiktari.ToString(), besin.KarbonhidratMiktari.ToString() };
                    ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
                    lstBesinItem.Tag = besin;
                    lstvKulaniciBesinleri.Items.Add(lstBesinItem);
                }
            }
        }

        private void lstvBesinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvBesinler.SelectedItems.Count > 0)
            {
                Besin seciliBesin = (Besin)lstvBesinler.SelectedItems[0].Tag;
                Id = seciliBesin.ID;

            }
        }

        private void lstvKulaniciBesinleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvKulaniciBesinleri.SelectedItems.Count > 0)
            {
                Besin seciliBesin = (Besin)lstvKulaniciBesinleri.SelectedItems[0].Tag;
                Id = seciliBesin.ID;

            }

        }




        private void btnBesinEkle_Click(object sender, EventArgs e)
        {

            if (Id < 0 || Id == null || Id == 0)
            {
                MessageBox.Show("Lütfen bir besin seçiniz.");
                return;
            }
            else
            {
                Besin besin = BContext.GetBesinByID(Id);
                BesinEklemeEkrani besinEklemeEkrani = new BesinEklemeEkrani(besin, Ogun);
                besinEklemeEkrani.ShowDialog();


                Besin DegisenBesin = BContext.OgununBesininiBul(Ogun);
                if (DegisenBesin == null)
                {
                    string[] BesinBilgiler = { besin.Ad, besin.Kalori.ToString(), besin.YagMiktari.ToString(), besin.ProteinMiktari.ToString(), besin.KarbonhidratMiktari.ToString() };
                    ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
                    lstBesinItem.Tag = besin;
                    lstSeciliBesinler.Items.Add(lstBesinItem);
                    SeciliBesinler.Add(besin);
                    Id = 0;

                }
                else
                {
                    string[] DegisenBesinBilgiler = { DegisenBesin.Ad, DegisenBesin.Kalori.ToString(), DegisenBesin.YagMiktari.ToString(), DegisenBesin.ProteinMiktari.ToString(), DegisenBesin.KarbonhidratMiktari.ToString() };
                    ListViewItem lstBesinItem = new ListViewItem(DegisenBesinBilgiler);
                    lstBesinItem.Tag = DegisenBesin;
                    lstSeciliBesinler.Items.Add(lstBesinItem);
                    SeciliBesinler.Add(DegisenBesin);
                    Id = 0;
                }
            }
        }



        private void btnBesinlereBesinEkle_Click(object sender, EventArgs e)
        {
            YeniBesinEklemeEkrani ybe = new YeniBesinEklemeEkrani();
            ybe.Show();

        }

        private void btnBesinDuzenleSil_Click(object sender, EventArgs e)
        {
            if (!BContext.OnayliMi(Id))
            {
                MessageBox.Show("Lütfen seçili besinlerimden bir adet düzenlenecek besin seçiniz.");
                return;
            }

            YeniBesinEklemeEkrani ybe = new YeniBesinEklemeEkrani(Id);
            ybe.Show();

        }


        private void btnOgunOlustur_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaEkran anaEkran = new AnaEkran(kullaniciID);
            anaEkran.Show();
        }

        private void btnBesinBul_Click(object sender, EventArgs e)
        {
            List<Besin> onayliBesinAramalari = BContext.BesinBul(txtArama.Text.ToLower());
            if (onayliBesinAramalari.Count > 0)
            {
                lstvBesinler.Items.Clear();
                foreach (Besin besin in onayliBesinAramalari)
                {
                    string[] BesinBilgiler = { besin.Ad, besin.Kalori.ToString(), besin.YagMiktari.ToString(), besin.ProteinMiktari.ToString(), besin.KarbonhidratMiktari.ToString() };
                    ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
                    lstBesinItem.Tag = besin;
                    lstvBesinler.Items.Add(lstBesinItem);
                }

            }
            else
            {
                MessageBox.Show("Default eklenen besinlerde aradığınız ürün bulunamadı.");
            }
            List<Besin> OnaysizBesinAramalari = BContext.OnaysizBesinlerdenAramaYap(txtArama.Text.ToLower());
            if (OnaysizBesinAramalari.Count > 0)
            {
                lstvKulaniciBesinleri.Clear();
                foreach (Besin besin in OnaysizBesinAramalari)
                {
                    string[] BesinBilgiler = { besin.Ad, besin.Kalori.ToString(), besin.YagMiktari.ToString(), besin.ProteinMiktari.ToString(), besin.KarbonhidratMiktari.ToString() };
                    ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
                    lstBesinItem.Tag = besin;
                    lstvKulaniciBesinleri.Items.Add(lstBesinItem);
                }
            }
            //else
            //{ MessageBox.Show("Eklediğiniz besinler de böyle bir besin bulunumadı."); }
        }

    }
}
