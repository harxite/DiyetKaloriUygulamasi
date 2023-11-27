using AppDiet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? DegistirilmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public Durum Durum { get; set; }
    }
}

