using System;

namespace Labo5.Exercice_1
{
    class Todo<T> where T : IComparable
    {
        static private readonly int INCRÉMENT = 5;
        private T[] appels;
        private int nbAppels;
        public Todo ()
        {
            appels = new T[INCRÉMENT];
            nbAppels = 0;
        }
        public bool EstVide ()
        {
            return nbAppels == 0;
        }
        public void Ajoute (T appel)
        {
            if (!Contient(appel))
            {
                if (nbAppels >= appels.Length)
                {
                    T[] nvAppels = new T[appels.Length + INCRÉMENT];
                    for (int i = 0; i < nbAppels; i++)
                    {
                        nvAppels[i] = appels[i];
                    }
                    appels = nvAppels;
                }
                appels[nbAppels] = appel;
                nbAppels++;
            }
        }
        // Précondition : on n'appelle AppelLu que
        // dans le cas où le Todo n'est pas vide !
        public T AppelLu ()
        {
            T résultat = appels[0];
            int i = 1;
            while (i < nbAppels)
            {
                appels[i - 1] = appels[i];
                i++;
            }
            nbAppels--;
            return résultat;
        }

        public bool Contient(T AppelAdd)
        {
            bool contientNuméro = false;
            
            foreach (T appel in appels)
            {
                contientNuméro = AppelAdd.CompareTo(appel) == 0;
                if (contientNuméro)
                    return contientNuméro;
            }
            return contientNuméro;
        }
    }
}