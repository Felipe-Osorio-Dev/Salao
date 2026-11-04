using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Config
{
    public class AppointmentConfig : IEntityTypeConfiguration<Appointments>
    {
        public void Configure(EntityTypeBuilder<Appointments> builder)
        {
            builder.ToTable("Agendamentos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Date)
                .IsRequired();

            builder.Property(a => a.CustomerId)
                .IsRequired();

            builder.HasOne(a => a.Customer)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.CustomerId)
                .IsRequired();

            builder.HasMany(a => a.AppointmentServices)
                .WithOne(s => s.Appointment)
                .HasForeignKey(s => s.AppointmentId)
                .IsRequired();

        }
    }
}
