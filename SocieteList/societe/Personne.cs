using System;
using System.Collections.Generic;
using System.Text;

namespace Societe
{
    class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public Personne() { }

        public void afficher()
        {
            Console.WriteLine(this.ToString());
        }

         public static Personne operator ++ (Personne p)
         {
            p.age += 1;
            return p; 
         }


        public override string ToString()
        {
            return $"{nom} {prenom} {age} \n";
        }
    }
}
