using SehirOtomasyonuMvc.Models;
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sehir>().ToTable("tblSehirler");
            modelBuilder.Entity<Sehir>().Property(o => o.SehirAd).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Sehir>().Property(o => o.TarihiEser).HasColumnType("varchar").HasMaxLength(75).IsRequired();
        }
    }
}