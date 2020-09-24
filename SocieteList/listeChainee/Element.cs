using System;
using System.Collections.Generic;
using System.Text;

namespace listeChainee
{
    class Element
    {
        public Object objet {get; set;}
        public Element suivant { get; set; }
        


        public Element (Object objet)
        {
            this.objet = objet;
            this.suivant = null;
        }


    }
}
