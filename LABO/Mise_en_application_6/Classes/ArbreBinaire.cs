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

        public Noeud ConstruireArbreTest()
        {
            Noeud racine = new Noeud(1);
            racine.Gauche = new Noeud(2);
            racine.Droit = new Noeud(3);
            racine.Gauche.Gauche = new Noeud(4);
            racine.Gauche.Droit = new Noeud(5);
            racine.Droit.Droit = new Noeud(6);
            racine.Gauche.Droit.Gauche = new Noeud(7);
            racine.Gauche.Droit.Droit = new Noeud(8);
            racine.Droit.Droit.Gauche = new Noeud(9);
            return racine;
        }

        //  calcule la profondeur d’un arbre binaire
        public int CalculerProfondeur(Noeud racine)
        {
            // Cas de base : Si l'arbre est vide (ou si on atteint une feuille vide) 
            if (racine == null)
            {
                return 0;
            }

            // Appel récursif pour calculer la profondeur du sous-arbre gauche
            int profondeurGauche = CalculerProfondeur(racine.Gauche);

            // Appel récursif pour calculer la profondeur du sous-arbre droit
            int profondeurDroite = CalculerProfondeur(racine.Droit);

            // La profondeur totale est 1 (le nœud actuel) + le maximum des deux sous-arbres
            if (profondeurGauche > profondeurDroite)
            {
                return 1 + profondeurGauche;
            }
            else
            {
                return 1 + profondeurDroite;
            }
        }

        public bool RechercherElement(Noeud racine, int valeur)
        {
            // 1. Cas de base : Si le nœud est vide, la valeur n'est pas ici.
            if (racine == null)
            {
                return false;
            }

            // 2. Cas de succès : Si la valeur du nœud actuel correspond à la valeur cherchée.
            if(racine.Valeur == valeur)
            {
                return true;
            }

            // 3. Récursion : On cherche dans le sous-arbre GAUCHE 
            //    OU (||) dans le sous-arbre DROIT.
            // Si l'un des deux retourne vrai, alors la fonction retourne vrai.
            return RechercherElement(racine.Gauche, valeur) || RechercherElement(racine.Droit, valeur);

        }
    }
}
