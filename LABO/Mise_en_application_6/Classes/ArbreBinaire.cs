using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mise_en_application_6.Classes
{
    public class ArbreBinaire
    {
        public Noeud Racine { get; set; }

        public void ConstruireArbre()
        {
            // Construction de l'arbre tel qu'illustré
            //       1
            //      / \
            //     2   3
            //    / \   \
            //   4   5   6
            //      / \  /
            //     7   8 9

            // Racine
            Racine = new Noeud(1);

            // niveau 2
            Racine.Gauche = new Noeud(2);
            Racine.Droit = new Noeud(3);

            //niveau 3
            Racine.Gauche.Gauche = new Noeud(4);
            Racine.Gauche.Droit = new Noeud(5);
            Racine.Droit.Droit = new Noeud(6);

            // niveau 5
            Racine.Gauche.Droit.Gauche = new Noeud(7);
            Racine.Gauche.Droit.Droit = new Noeud(8);
            Racine.Droit.Droit.Gauche = new Noeud(9);

            Console.WriteLine("Arbre construit avec succès!");

            // Affichage des différents parcours
            Console.WriteLine("Parcours Préfixé (Racine-Gauche-Droit):");
            ParcoursPrefixe(Racine);
            Console.WriteLine();

            Console.WriteLine("\nParcours Infixé (Gauche-Racine-Droit):");
            ParcoursInfixe(Racine);
            Console.WriteLine();

            Console.WriteLine("\nParcours Postfixé (Gauche-Droite-Racine):");
            ParcoursPostfixe(Racine);
            Console.WriteLine();
        }

        // Parcours préfixé : Racine → Gauche → Droit
        private void ParcoursPrefixe(Noeud noeud)
        {
            if (noeud != null)
            {
                Console.Write(noeud.Valeur + ", ");
                ParcoursPrefixe(noeud.Gauche);
                ParcoursPrefixe(noeud.Droit);
            }
        }

        // Parcours infixé : Gauche → Racine → Droit
        private void ParcoursInfixe(Noeud noeud)
        {
            if (noeud != null)
            {
                ParcoursInfixe(noeud.Gauche);
                Console.Write(noeud.Valeur + ", ");
                ParcoursInfixe(noeud.Droit);
            }
        }

        // Parcours postfixé : Gauche → Droit → Racine
        private void ParcoursPostfixe(Noeud noeud)
        {
            if (noeud != null)
            {
                ParcoursPostfixe(noeud.Gauche);             
                ParcoursPostfixe(noeud.Droit);
                Console.Write(noeud.Valeur + ", ");
            }
        }

    }
}
