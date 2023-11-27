using AppDiet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.Domain.Entities
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int Boy { get; set; }
        public double Kilo { get; set; }
        public AktiviteDuzeyi AktiviteDuzeyi  { get; set; }
        public double HedefKilo { get; set; }
        public KullaniciTipi KullaniciTipi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public ICollection<GunlukDetay> GunlukDetaylar { get; set; }

    }
}
