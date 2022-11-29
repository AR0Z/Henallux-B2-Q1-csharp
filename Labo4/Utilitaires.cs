namespace Labo4
{
    public static class Utilitaires
    {
        public static bool GrandNamur(int codePostal)
        {
            return codePostal / 100 == 50;
        }

        public static bool RegionWallonne(int codePostal)
        {
            return (1300 <= codePostal && codePostal <= 1499) || (4000  <= codePostal && codePostal <= 7999);
        }
    }
}