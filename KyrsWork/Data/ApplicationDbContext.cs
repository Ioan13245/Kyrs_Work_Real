using KyrsWork.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace KyrsWork.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Service> Services { get; set; } = default!;
        public DbSet<Supplier> Suppliers { get; set; } = default!;
        public DbSet<Tire> Tires { get; set; } = default!;
        public DbSet<Wheel> Wheels { get; set; } = default!;
        public DbSet<Shipment> Shipment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Tire>()
                .HasOne(t => t.Service) // Каждая шина относится к одной услуге
                .WithMany(s => s.Tires) // Услуга может иметь много шин
                .HasForeignKey(t => t.ServiceId); // Устанавливаем внешний ключ

            builder.Entity<Wheel>()
                .HasOne(w => w.Service) // Каждый диск относится к одной услуге
                .WithMany(s => s.Wheels) // Услуга может иметь много дисков
                .HasForeignKey(w => w.ServiceId); // Устанавливаем внешний ключ
            
        }
    }
}
