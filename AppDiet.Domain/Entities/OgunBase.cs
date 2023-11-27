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
        public int AlinanToplamKalori { get; set; }
        public double AlinanToplamYag { get; set; }
        public double AlinanToplamProtein { get; set; }
        public double AlinanToplamKarbonhidrat { get; set; }
        public ICollection<Besin> Besinler { get; set; }
        public ICollection<GunlukDetay> GunlukDetaylar { get; set; }
    }
}
