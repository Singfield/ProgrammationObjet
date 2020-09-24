using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau.models
{
    class Chef : Employe
    {
        public string  Service {get; set;}
        public Chef (string nom, string prenom, int age, int _Salaire, string Service): base (nom,prenom, age,_Salaire)
        {
            this.Service = Service;
        }

        public override string ToString()
        {
            return $" Employe {nom} {prenom} {age} {_Salaire} {Service} \n";
        }
    }
}
