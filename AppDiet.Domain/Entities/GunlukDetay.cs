using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.Domain.Entities
{
    public class GunlukDetay
    {
        public int GunlukDetayId { get; set; }
        public int GunlukKaloriIhtiyaci { get; set; }
        public int AlinanToplamKalori { get; set; }
        public double AlinanToplamYag { get; set; }
        public double AlinanToplamProtein { get; set; }
        public double AlinanToplamKarbonhidrat { get; set; }
        public Kahvalti Kahvalti { get; set; }
        public int? KahvaltiID { get; set; }

        public OgleYemegi OgleYemegi { get; set; }
        public int? OgleYemegiID { get; set; }

        public AksamYemegi AksamYemegi { get; set; }
        public int? AksamYemegiID { get; set; }

        public AraOgun AraOgun { get; set; }
        public int? AraOgunID { get; set; }

        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get; set; }
    }
}
