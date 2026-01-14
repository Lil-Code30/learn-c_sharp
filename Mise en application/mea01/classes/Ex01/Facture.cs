namespace Mise_en_application.mea01.classes.Ex01
{
    // Mise en application 01 - Ex01
    /* 1. Créer une classe Facture contenant :
        a. Attributs : Client, Vendeur & Articles
        b. Méthodes : Calcul prix total, ajouter un Article & Afficher */
    public class Facture
    {
        private string Client;
        private string Vendeur;
        private List<Article> Articles;

        public Facture(string client, string vendeur)
        {
            this.Client = client;
            this.Vendeur = vendeur;
            this.Articles = new List<Article>();
        }

        public float calculPrixTotal()
        {
            float total = 0;

            foreach(Article article in Articles)
            {

                total = total + article.prixTotal;
            }

            return total;
        }

        public void ajoutArticle(Article article)
        {
            Articles.Add(article);
        }

        public void afficher()
        {
            
            Console.WriteLine($"\n=== FACTURE ===");
            Console.WriteLine($"Client: {Client}");
            Console.WriteLine($"Vendeur: {Vendeur}");
            Console.WriteLine("Articles:");
            foreach (var article in Articles)
            {
                article.afficher();
            }
            Console.WriteLine($"TOTAL: {calculPrixTotal():C}");
            Console.WriteLine("================\n");
        }
    }
}