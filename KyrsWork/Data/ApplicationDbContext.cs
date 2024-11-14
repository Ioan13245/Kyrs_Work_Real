using KyrsWork.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KyrsWork.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Service> Services { get; set; } = default!;
        public DbSet<Supplier> Suppliers { get; set; } = default!;
        public DbSet<Tire> Tires { get; set; } = default!;
        public DbSet<Wheel> Wheels { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
