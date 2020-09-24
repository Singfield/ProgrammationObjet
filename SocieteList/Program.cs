using System;
using Societe;
using listeChainee;
namespace SocieteList
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste list = new Liste();

            Employe E1 = new Employe("bob", "Lennon", 25, 10000);
            Employe E2 = new Employe("Ayden", "Hex", 23, 11000);
            Employe E3 = new Employe("Shyroe", "Heroe", 25, 120000);
            Employe E4 = new Employe("Kusanagi", "Major", 25, 13000);
            Employe E5 = new Employe("Haridoudou", "Pitchu", 25, 14000);

            Chef CH1 = new Chef("Joseph", "Joestar", 25, 14000, "Action");
            Chef CH2 = new Chef("David", "504", 25, 14000, "Music");

            Directeur D1 = new Directeur("Dio", "Brando", 25, 14000, "Action", "muda");

            list.InsererDebut(E1);
            list.InsererDebut(E2);
            list.InsererDebut(E3);
            list.InsererDebut(E4);
            list.InsererDebut(E5);
            list.InsererDebut(CH1);
            list.InsererDebut(CH2);
            list.InsererDebut(D1);

            list.Lister();

            list.Vider();

            list.InsererFin(E1);
            list.InsererFin(E2);
            list.InsererFin(E3);
            list.InsererFin(E4);
            list.InsererFin(E5);
            list.InsererFin(CH1);
            list.InsererFin(CH2);
            list.InsererFin(D1);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[6]);

        }
    }
}
