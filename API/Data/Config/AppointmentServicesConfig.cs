using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Config
{
    public class AppointmentServicesConfig : IEntityTypeConfiguration<AppointmentServices>
    {
        public void Configure(EntityTypeBuilder<AppointmentServices> builder)
        {
            builder.ToTable("ServiçosAgendados");

            builder.HasKey(x => new { x.AppointmentId, x.ServiceId });

            builder.HasOne(x => x.Appointment)
                .WithMany(a => a.AppointmentServices)
                .HasForeignKey(x => x.AppointmentId)
                .IsRequired();

            builder.HasOne(x => x.Service)
                .WithMany(s => s.AppointmentServices)
                .HasForeignKey(x => x.ServiceId)
                .IsRequired();

            builder.Property(x => x.ServiceValue)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}
