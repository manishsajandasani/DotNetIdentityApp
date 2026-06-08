namespace DotNetIdentityApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        // Tenant isolation
        public int TenantId { get; set; }
        public Tenant? Tenant { get; set; } = null;

        // Fields
        public string FullName { get; set; } = string.Empty;
        public string EnrollmentNo { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Course { get; set; }
        public int? Year { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
