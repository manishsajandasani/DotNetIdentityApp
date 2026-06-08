using DotNetIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetIdentityApp.Data.Configurations
{
    public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Code)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.HasIndex(x => x.Code)
                   .IsUnique();

            builder.Property(x => x.Phone)
                   .HasMaxLength(20);

            builder.Property(x => x.Email)
                   .HasMaxLength(200);
        }
    }
}
