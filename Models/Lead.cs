namespace DotNetIdentityApp.Models
{
    public enum LeadStatus
    {
        New,
        Contacted,
        Interested,
        Converted,
        Lost
    }

    public class Lead
    {
        public int Id { get; set; }

        // Tenant isolation
        public int TenantId { get; set; }
        public Tenant? Tenant { get; set; }

        // Fields
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? InterestedCourse { get; set; }
        public LeadStatus Status { get; set; } = LeadStatus.New;
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
