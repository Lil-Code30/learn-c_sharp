
namespace Mise_en_application_01.classses
{
    /* 
        2. Créer une classe Article contenant :
            a. Attributs : titre, quantité & prix unitaire
            b. Méthodes : Afficher
    */
    public class Article
    {
        private string Titre;
        private int Quantite;
        private float PrixUnitaire;

        public Article(string titre, int quantite, float prixUnitaire)
        {
            this.Titre = titre;
            this.Quantite = quantite;
            this.PrixUnitaire = prixUnitaire;
        }

        public float prixTotal()
        {
            return Quantite * PrixUnitaire;
        }

        public void afficher()
        {
            Console.WriteLine($"Titre Article: {Titre}");
            Console.WriteLine($"Quantité : {Quantite}");
            Console.WriteLine($"Prix Unitaire : {PrixUnitaire}");
            Console.WriteLine("================\n");
        }

    }
}
