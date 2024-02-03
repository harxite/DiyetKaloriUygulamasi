using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.Domain.Entities
{
    public abstract class OgunBase 
    {
        public int ID { get; set; }
        public int AlinanToplamKalori { get; set; } = 0;
        public double AlinanToplamYag { get; set; } = 0;
        public double AlinanToplamProtein { get; set; } = 0;
        public double AlinanToplamKarbonhidrat { get; set; } = 0;
        public ICollection<Besin> Besinler { get; set; }
        public ICollection<GunlukDetay> GunlukDetaylar { get; set; }
    }
}
