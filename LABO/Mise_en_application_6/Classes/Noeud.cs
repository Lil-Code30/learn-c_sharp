namespace Mise_en_application_6.Classes
{
    // Classe représentant un nœud de l'arbre binaire
    public class Noeud
    {
        public int Valeur { get; set; }
        public Noeud Gauche { get; set; }
        public Noeud Droit { get; set; }

        public Noeud(int valeur)
        {
            Valeur = valeur;
            Gauche = null;
            Droit = null;
        }
    }
}
