using System;
using System.Collections.Generic;
using System.Text;

namespace listeChainee
{
    class Liste
    {
        public Element debut {get; set;}

        public int nbElement { get; set; }

        public Liste()
        {
            this.debut = null;
            this.nbElement = 0;
        }

        //Road to coffee and coke

        public void InsererDebut(Object objet)
        {
            Element element = new Element(objet);

            if (this.debut == null)
            {
                this.debut = element;
                return;
            }

            Element aInserer = this.debut;
            this.debut = element;
            this.debut.suivant = aInserer;
            this.nbElement++;

        }

        public void InsererFin(Object objet)
        {
            Element element = new Element(objet);
            if (this.debut == null)
            {
                this.debut = element;
                return;
            }

            Element actuel = this.debut;
            while (actuel.suivant != null)
            {
               actuel = actuel.suivant;
            }

           
            actuel.suivant = element;
            this.nbElement++;
        }

        public void Lister()
        {
            Element actuel = this.debut;
            if (this.debut != null)
            {

                while (actuel.suivant != null)
                {
                    Console.WriteLine(actuel.objet);
                    actuel = actuel.suivant;
                }
                Console.WriteLine(actuel.objet);
            }
        }
        public void Vider()
        {
            debut = null;
        }


        public Element this[int index]
        {
            get // élément [index] lu
            {
                if (index > this.nbElement)
                {
                    Console.WriteLine("Out of range");
                }
                Element actuel = this.debut;
                for (int i = 0; i < index; i++)
                {
                    actuel = actuel.suivant;
                }
                return actuel;
            }
        }
    }
}
