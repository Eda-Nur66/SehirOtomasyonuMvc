using SehirOtomasyonuMvc.Models;
using SehirOtomasyonuMvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SehirOtomasyonuMvc.DAL
{
    public class TurkeyContext : DbContext
    {
        public TurkeyContext():base("cstr")
        {

        }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Bolge>Bolgeler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sehir>().ToTable("tblSehirler");
            modelBuilder.Entity<Sehir>().Property(s => s.SehirAd).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Sehir>().Property(s => s.TarihiEser).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Bolge>().ToTable("tblBolgeler");
            modelBuilder.Entity<Bolge>().Property(b => b.BolgeAd).HasColumnType("varchar").HasMaxLength(50).IsRequired();

        }
        

        }
}