using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau.models
{
    class Employe : Personne
    {
        public int _Salaire {get; set;}
        
        public Employe (string nom, string prenom, int age, int _Salaire) : base(nom, prenom, age)
        {
            this._Salaire = _Salaire;
        }

        public override string ToString()
        {
            return $" Employe {nom} {prenom} {age} {_Salaire} \n";
        }
    }
}
