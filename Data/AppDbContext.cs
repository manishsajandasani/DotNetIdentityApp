using DotNetIdentityApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetIdentityApp.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tenant> Tenants => Set<Tenant>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Lead> Leads => Set<Lead>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Tenant
            builder.Entity<Tenant>(t =>
            {
                t.HasKey(x => x.Id);
                t.Property(x => x.Name).IsRequired().HasMaxLength(200);
                t.Property(x => x.Code).IsRequired().HasMaxLength(20);
                t.HasIndex(x => x.Code).IsUnique();
            });

            // ApplicationUser → Tenant
            builder.Entity<ApplicationUser>(u =>
            {
                u.HasOne(x => x.Tenant)
                 .WithMany(t => t.Users)
                 .HasForeignKey(x => x.TenantId)
                 .IsRequired(false)
                 .OnDelete(DeleteBehavior.Restrict);

                u.Property(x => x.FullName).HasMaxLength(200);
            });

            // Student
            builder.Entity<Student>(s =>
            {
                s.HasKey(x => x.Id);
                s.Property(x => x.FullName).IsRequired().HasMaxLength(200);
                s.Property(x => x.EnrollmentNo).IsRequired().HasMaxLength(50);
                s.HasIndex(x => new { x.TenantId, x.EnrollmentNo }).IsUnique();

                s.HasOne(x => x.Tenant)
                 .WithMany()
                 .HasForeignKey(x => x.TenantId)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // Course
            builder.Entity<Course>(c =>
            {
                c.HasKey(x => x.Id);
                c.Property(x => x.Title).IsRequired().HasMaxLength(200);
                c.Property(x => x.Fees).HasColumnType("decimal(10,2)");

                c.HasOne(x => x.Tenant)
                 .WithMany()
                 .HasForeignKey(x => x.TenantId)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // Lead
            builder.Entity<Lead>(l =>
            {
                l.HasKey(x => x.Id);
                l.Property(x => x.FullName).IsRequired().HasMaxLength(200);
                l.Property(x => x.Status).HasConversion<string>();

                l.HasOne(x => x.Tenant)
                 .WithMany()
                 .HasForeignKey(x => x.TenantId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
