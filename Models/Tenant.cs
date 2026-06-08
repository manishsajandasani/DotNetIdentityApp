namespace DotNetIdentityApp.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();

        /**
         We can have a collection of students here if we want to navigate from Tenant to Students, but it's not strictly necessary for the core functionality of tenant isolation.
         */
        //public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
