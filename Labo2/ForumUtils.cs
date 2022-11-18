using System;
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

        public static int SpaceCount(string txt)
        {
            int spaceCount=0;
            for (int i = 0;i < txt.Length;i++)
            {
                if (txt[i] == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }

        public static int DigitCount(string txt)
        {
            int digitCount=0;
            for (int i = 0;i < txt.Length;i++)
            {
                if (Char.IsDigit(txt[i]))
                    digitCount++;
            }
            return digitCount;
        }

        public static void Count(string txt, out int spaceCount, out int digitCount)
        {
            digitCount=0;
            spaceCount=0;
            
            for (int i = 0;i < txt.Length;i++)
            {
                if (Char.IsDigit(txt[i]))
                    digitCount++;
                if (txt[i] == ' ')
                    spaceCount++;
            }
        }

        public static void CountAndUpdate(string txt, ref int spaceCount, ref int digitCount)
        {
            for (int i = 0;i < txt.Length;i++)
            {
                if (Char.IsDigit(txt[i]))
                    digitCount++;
                if (txt[i] == ' ')
                    spaceCount++;
            }
        }
    }
}