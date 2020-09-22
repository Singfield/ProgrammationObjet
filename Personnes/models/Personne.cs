﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes.models
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

        public void afficher()
        {
            Console.WriteLine($"{nom} {prenom} {age}");
        }

    }
}
