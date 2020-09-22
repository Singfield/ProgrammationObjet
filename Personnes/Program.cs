using System;
using Personnes.models;
namespace Personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne =new Personne("Jean", "EyeMarre",20);
            personne.afficher();
        }
    }
}
