using Sklad_project_2.Models;

namespace Sklad_project_2
{
    public static class CurrentUser
    {
        public static User User { get; set; }
        public static string RoleName { get; set; }

        public static bool IsAdmin => RoleName == "Администратор";
        public static bool IsStorekeeper => RoleName == "Кладовщик";
    }
}