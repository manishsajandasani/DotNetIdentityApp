namespace DotNetIdentityApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        // Tenant isolation
        public int TenantId { get; set; }
        public Tenant? Tenant { get; set; }

        // Fields
        public string Title { get; set; } = string.Empty;
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? Department { get; set; }
        public int? DurationMonths { get; set; }
        public decimal? Fees { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
