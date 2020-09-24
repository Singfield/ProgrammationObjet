using System;
using System.Collections.Generic;
using System.Text;

namespace Societe
{
    class Directeur :Chef
    {
        public string Societe;
        public Directeur (string nom, string prenom, int age, int _Salaire, string Service, string societe) : base(nom, prenom, age, _Salaire, Service)
        {
            this.Societe = societe;
        }

        public override string ToString()
        {
            return $" Employe {nom} {prenom} {age} {_Salaire} {Service} {Societe} \n";
        }
    }
}
