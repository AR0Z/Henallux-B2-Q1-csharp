using System;

namespace Labo3
{
    public static class UtilTV
    {
        public static void AfficheProgramme(params Émission[] émissionsListe)
        {
            foreach (Émission émission in émissionsListe)
            {
                Console.WriteLine(émission.Présentation());
            }
        }

        public static void PrésenteDA(params DessinAnimé[] das)
        {
            foreach (DessinAnimé da in das)
            {
                Console.WriteLine(da.Présentation());
            }
        }
    }
}