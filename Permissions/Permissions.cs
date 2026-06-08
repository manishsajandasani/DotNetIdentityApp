namespace DotNetIdentityApp.Permissions;

public static class Permissions
{
    public static class Tenants
    {
        public const string View = "tenants.view";
        public const string Create = "tenants.create";
        public const string Edit = "tenants.edit";
        public const string Delete = "tenants.delete";
    }

    public static class Users
    {
        public const string View = "users.view";
        public const string Create = "users.create";
        public const string Edit = "users.edit";
        public const string Delete = "users.delete";
    }

    public static class Students
    {
        public const string View = "students.view";
        public const string Create = "students.create";
        public const string Edit = "students.edit";
        public const string Delete = "students.delete";
    }

    public static class Courses
    {
        public const string View = "courses.view";
        public const string Create = "courses.create";
        public const string Edit = "courses.edit";
        public const string Delete = "courses.delete";
    }

    public static class Leads
    {
        public const string View = "leads.view";
        public const string Create = "leads.create";
        public const string Edit = "leads.edit";
        public const string Delete = "leads.delete";
    }

    public static IEnumerable<string> GetAll() =>
    [
        Tenants.View,  Tenants.Create,  Tenants.Edit,  Tenants.Delete,
        Users.View,    Users.Create,    Users.Edit,    Users.Delete,
        Students.View, Students.Create, Students.Edit, Students.Delete,
        Courses.View,  Courses.Create,  Courses.Edit,  Courses.Delete,
        Leads.View,    Leads.Create,    Leads.Edit,    Leads.Delete,
    ];
}

public static class AppRoles
{
    public const string SuperAdmin = "SuperAdmin";
    public const string Admin = "Admin";
    public const string Teacher = "Teacher";
    public const string Student = "Student";

    public static readonly string[] All = [SuperAdmin, Admin, Teacher, Student];
}