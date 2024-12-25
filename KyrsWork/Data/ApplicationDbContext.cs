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
                .HasOne(t => t.Service) // ������ ���� ��������� � ����� ������
                .WithMany(s => s.Tires) // ������ ����� ����� ����� ���
                .HasForeignKey(t => t.ServiceId); // ������������� ������� ����

            builder.Entity<Wheel>()
                .HasOne(w => w.Service) // ������ ���� ��������� � ����� ������
                .WithMany(s => s.Wheels) // ������ ����� ����� ����� ������
                .HasForeignKey(w => w.ServiceId); // ������������� ������� ����
            
        }
    }
}
