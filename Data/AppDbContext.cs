using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option)
    : base(option) 
        {
        }
        public DbSet<Maestro> Maestro { get; set; }
        public DbSet<Salon> Salon { get; set; }
        //public DbSet<MaestroSalon> MaestroSalon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            
            //Maestro
            modelBuilder.Entity<Maestro>()
                .HasKey(maestro => maestro.MaestroId);
            modelBuilder.Entity<Maestro>()
                .HasMany(maestro => maestro.MaestroSalon);
           
            //Salon
            modelBuilder.Entity<Salon>()
                .HasKey(salon => salon.SalonId);
            modelBuilder.Entity<Salon>()
                .HasMany(salon => salon.SalonMaestro);
            
            //Maestro-Salon
            modelBuilder.Entity<MaestroSalon>()
                .HasKey(ms => new {ms.MaestroId, ms.SalonId });
            modelBuilder.Entity<MaestroSalon>()
                .HasOne<Maestro>(ms => ms.Maestro)
                .WithMany(maestro => maestro.MaestroSalon)
                .HasForeignKey(maestro => maestro.MaestroId);
            modelBuilder.Entity<MaestroSalon>()
                .HasOne<Salon>(ms => ms.Salon)
                .WithMany(salon => salon.SalonMaestro)
                .HasForeignKey(salon => salon.SalonId);
        }
    }
}
