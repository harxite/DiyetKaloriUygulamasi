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

namespace DietApp.UI
{
    public partial class BesinFotografiEkrani : Form
    {
        private Besin besin;

        public BesinFotografiEkrani()
        {
            InitializeComponent();
        }

        public BesinFotografiEkrani(Besin besin)
        {
            InitializeComponent();
            this.besin = besin;
        }

        private void BesinFotografiEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = besin.Fotograf;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bu besine ait bir fotograf bulunamadi !");
            }
        }

    }
}
