using AppDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.DAL.Configurations
{
    internal class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(50);
            builder.Property(x => x.Soyad).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(75);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Sifre).HasMaxLength(50);
            builder.Property(x => x.Yas).HasMaxLength(2);
            builder.Property(x => x.Boy).HasMaxLength(3);
            builder.Property(x => x.Kilo).HasMaxLength(3);
            builder.Property(x => x.HedefKilo).HasMaxLength(3);
           
        }
    }

}
