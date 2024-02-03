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
        public int Miktar { get; set; } = 1;
        public int Kalori { get; set; }
        public double? ProteinMiktari { get; set; }
        public double? YagMiktari { get; set; }
        public double? KarbonhidratMiktari { get; set; }
        public Kahvalti Kahvalti { get; set; }
        public int? KahvaltiID { get; set; }

        public OgleYemegi OgleYemegi { get; set; }
        public int? OgleYemegiID { get; set; }

        public AksamYemegi AksamYemegi { get; set; }
        public int? AksamYemegiID { get; set; }

        public AraOgun AraOgun { get; set; }
        public int? AraOgunID { get; set; }
        public bool OnayliMi { get; set; }
    }
}
