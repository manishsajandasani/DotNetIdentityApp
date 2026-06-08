using DotNetIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetIdentityApp.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.EnrollmentNo)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(x => new { x.TenantId, x.EnrollmentNo })
                   .IsUnique();

            builder.Property(x => x.Email)
                   .HasMaxLength(200);

            builder.Property(x => x.Phone)
                   .HasMaxLength(20);

            builder.HasOne(x => x.Tenant)
                   .WithMany()
                   .HasForeignKey(x => x.TenantId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
