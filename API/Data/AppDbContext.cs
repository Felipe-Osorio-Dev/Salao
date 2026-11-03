using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Customers> Customers => Set<Customers>();
        public DbSet<Appointments> Appointments => Set<Appointments>();
        public DbSet<Services> Services => Set<Services>();
        public DbSet<AppointmentServices> AppointmentServices => Set<AppointmentServices>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
