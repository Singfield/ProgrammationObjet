using System;
using System.Collections.Generic;
using SocieteTableau.models;

namespace SocieteTableau
{
    class Program
    {
        static void Main(string[] args)
        {

            Employe E1= new Employe("bob", "Lennon", 25, 10000);
            Employe E2 = new Employe("Ayden", "Hex", 23, 11000);
            Employe E3 = new Employe("Shyroe", "Heroe", 25, 120000);
            Employe E4 = new Employe("Kusanagi", "Major", 25, 13000);
            Employe E5 = new Employe("Haridoudou", "Pitchu", 25, 14000);

            Chef CH1= new Chef("Joseph", "Joestar", 25, 14000, "Action");
            Chef CH2 = new Chef("David", "504", 25, 14000, "Music");

            Directeur D1=new Directeur("Dio", "Brando", 25, 14000, "Action", "muda");






            List<Personne> membres = new List<Personne>()
            {
               E1,
               E2,
               E3,
               E4,
               E5,
               CH1,
               CH2,
               D1
            };

            membres[0]++;

            CH1.Service = "SpeedWagon";
            CH1._Salaire = 200000;
            


            for (int i = 0; i != membres.Count; i++)
            {
                membres[i].afficher();
            }

            foreach (Personne membre in membres)
            {
                membre.afficher();
            }

           

            



        }
    }
}
