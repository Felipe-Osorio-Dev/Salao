using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Config
{
    public class ServicesConfig : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable("Serviços");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Description)
                .HasMaxLength(200);

            builder.HasMany(s => s.AppointmentServices)
                .WithOne(a => a.Service)
                .HasForeignKey(a => a.ServiceId)
                .IsRequired();
        }
    }
}
