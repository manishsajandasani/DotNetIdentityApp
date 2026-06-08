namespace DotNetIdentityApp.Permissions;

public static class AppRolePermissions
{
    public static IEnumerable<string> GetForRole(string role) => role switch
    {
        AppRoles.SuperAdmin => Permissions.GetAll(),

        AppRoles.Admin =>
        [
            Permissions.Users.View,    Permissions.Users.Create,
            Permissions.Users.Edit,    Permissions.Users.Delete,
            Permissions.Students.View, Permissions.Students.Create,
            Permissions.Students.Edit, Permissions.Students.Delete,
            Permissions.Courses.View,  Permissions.Courses.Create,
            Permissions.Courses.Edit,  Permissions.Courses.Delete,
            Permissions.Leads.View,    Permissions.Leads.Create,
            Permissions.Leads.Edit,    Permissions.Leads.Delete,
        ],

        AppRoles.Teacher =>
        [
            Permissions.Students.View, Permissions.Students.Create,
            Permissions.Students.Edit,
            Permissions.Courses.View,
            Permissions.Leads.View,
        ],

        AppRoles.Student =>
        [
            Permissions.Students.View,
            Permissions.Courses.View,
        ],

        _ => []
    };
}