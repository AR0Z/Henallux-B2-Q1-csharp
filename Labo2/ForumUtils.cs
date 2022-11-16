using System.Linq;

namespace Labo2
{
    public static class ForumUtils
    {
        public static string[] FORBIDDEN_LOGINS = new [] { "", "fart", "aroz" };

        public static bool ValidLogin(string login)
        {
            return !FORBIDDEN_LOGINS.Contains(login.ToLower());
        }
    }
}