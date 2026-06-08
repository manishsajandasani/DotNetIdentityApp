using Microsoft.AspNetCore.Identity;

namespace DotNetIdentityApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Tenant with Navigation Property of Tenant
        public int? TenantId { get; set; }
        public Tenant? Tenant { get; set; }

        // Profile
        public string FullName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Email OTP (per-user toggle)
        public bool IsEmailOtpEnabled { get; set; } = false;
        public string? EmailOtpCode { get; set; }
        public DateTime? EmailOtpExpiry { get; set; }
    }
}
