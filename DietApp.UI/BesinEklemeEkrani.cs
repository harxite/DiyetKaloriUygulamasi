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
    public partial class BesinEklemeEkrani : Form
    {
        public BesinEklemeEkrani()
        {
            InitializeComponent();
        }

        public BesinEklemeEkrani(Besin besin, OgunBase ogun)
        {
            InitializeComponent();
            Besin = besin;
            Ogun = ogun;
        }

        Besin Besin;
        OgunBase Ogun;
        BesinService bs;
        OgunService og;


        private void BesinEklemeEkrani_Load(object sender, EventArgs e)
        {
            bs = new BesinService();
            og = new OgunService();
            nudMiktar.Value = Besin.Miktar;
            cmbBirim.Text = Besin.PorsiyonBirimi.ToString();
            pbBesinFotograf.ImageLocation = Besin.Fotograf;
            string[] BesinBilgiler = { Besin.Ad, Besin.Kalori.ToString(), Besin.YagMiktari.ToString(), Besin.ProteinMiktari.ToString(), Besin.KarbonhidratMiktari.ToString(), Besin.Miktar.ToString() };
            ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
            lstBesinItem.Tag = Besin;
            lstGelenBesin.Items.Add(lstBesinItem);
        }

        private void dgwBesinler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudMiktar_ValueChanged(object sender, EventArgs e)
        {
            if (Besin != null)
            {
                double miktar = (double)nudMiktar.Value;

                double yeniProtein = (double)Besin.ProteinMiktari * miktar;
                double yeniKarbonhidrat = (double)Besin.KarbonhidratMiktari * miktar;
                double yeniYag = (double)Besin.YagMiktari * miktar;
                double yeniKalori = (double)Besin.Kalori * miktar;

                string[] BesinBilgiler = { Besin.Ad, Besin.Kalori.ToString(), yeniYag.ToString(), yeniProtein.ToString(), yeniKarbonhidrat.ToString(), miktar.ToString() };

                if (lstGelenBesin.Items.Count > 0)
                {
                    ListViewItem ilkItem = lstGelenBesin.Items[0];
                    ilkItem.SubItems[1].Text = yeniKalori.ToString();
                    ilkItem.SubItems[2].Text = yeniYag.ToString();
                    ilkItem.SubItems[3].Text = yeniProtein.ToString();
                    ilkItem.SubItems[4].Text = yeniKarbonhidrat.ToString();
                    ilkItem.SubItems[5].Text = miktar.ToString();
                }
                else
                {
                    ListViewItem lstBesinItem = new ListViewItem(BesinBilgiler);
                    lstBesinItem.Tag = Besin;
                    lstGelenBesin.Items.Add(lstBesinItem);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (nudMiktar.Value != Besin.Miktar)
            {
                Besin Besin = new Besin();
                Besin.Ad = this.Besin.Ad;
                Besin.Aciklama = this.Besin.Aciklama;
                Besin.ProteinMiktari = (double)nudMiktar.Value * this.Besin.ProteinMiktari;
                Besin.KarbonhidratMiktari = (double)nudMiktar.Value * this.Besin.KarbonhidratMiktari;
                Besin.Kalori = (int)nudMiktar.Value * this.Besin.Kalori;
                Besin.YagMiktari = (double)nudMiktar.Value * this.Besin.YagMiktari;
                Besin.Miktar = (int)nudMiktar.Value;
                Besin.Fotograf = this.Besin.Fotograf;
                Besin.Kategori = this.Besin.Kategori;
                Besin.PorsiyonBirimi = this.Besin.PorsiyonBirimi;
                Besin.Durum = Durum.Duzenlendi;
                Besin.OnayliMi = true;
                switch (Ogun)
                {
                    case Kahvalti:
                        Besin.KahvaltiID = Ogun.ID;
                        break;
                    case OgleYemegi:
                        Besin.OgleYemegiID = Ogun.ID;
                        break;
                    case AksamYemegi:
                        Besin.AksamYemegiID = Ogun.ID;
                        break;
                    case AraOgun:
                        Besin.AraOgunID = Ogun.ID;
                        break;
                    default:
                        break;
                }
             
                bs.YeniBesinekle(Besin);
                this.Close();

            }
            else
            {
                bs.Update(Besin);
                this.Close();
            }
        }
    }
}
