using AppDiet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.Domain.Entities
{
    public class Besin : BaseEntity
    {
        public string Ad { get; set; }
        public string? Aciklama { get; set; }
        public string? Fotograf { get; set; }
        public Kategori Kategori { get; set; }
        public PorsiyonBirimi PorsiyonBirimi { get; set; }
        public int Kalori { get; set; }
        public double? ProteinMiktari { get; set; }
        public double? YagMiktari { get; set; }
        public double? KarbonhidratMiktari { get; set; }
        public ICollection<Kahvalti> Kahvaltilar { get; set; }

        public ICollection<OgleYemegi> OgleYemekleri { get; set; }

        public ICollection<AksamYemegi> AksamYemekleri { get; set; }
        public ICollection<AraOgun> AraOgunler { get; set; }
        public bool OnayliMi { get; set; }
    }
}
