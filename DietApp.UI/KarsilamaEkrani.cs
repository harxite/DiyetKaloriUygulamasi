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
    public partial class KarsilamaEkrani : Form
    {
        public KarsilamaEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            this.Hide();
            girisEkrani.ShowDialog();
            this.Show();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            this.Hide();
            kayitEkrani.ShowDialog();
            this.Show();
        }
    }
}
