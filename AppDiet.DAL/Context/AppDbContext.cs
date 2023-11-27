using AppDiet.DAL.Configurations;
using AppDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiet.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<GunlukDetay> GunlukDetaylar { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<Kahvalti> Kahvaltilar { get; set; }
        public DbSet<OgleYemegi> OgleYemekleri { get; set; }
        public DbSet<AraOgun> AraOgunler { get; set; }
        public DbSet<AksamYemegi> AksamYemekleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-AMN0S4B\SQL_BA ; Initial Catalog=DiyetUygulamaDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BesinConfiguration())
                        .ApplyConfiguration(new KullaniciConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
