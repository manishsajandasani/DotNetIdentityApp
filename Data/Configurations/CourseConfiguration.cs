using DotNetIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetIdentityApp.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Code)
                   .HasMaxLength(20);

            builder.Property(x => x.Department)
                   .HasMaxLength(100);

            builder.Property(x => x.Fees)
                   .HasColumnType("decimal(10,2)");

            builder.HasOne(x => x.Tenant)
                   .WithMany()
                   .HasForeignKey(x => x.TenantId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
