namespace mise_en_application_02_05
{
    public class Produit : IStockable
    {
        public string Nom { get; }
        public double Prix { get; }
        public int Quantite { get; set; }

        public Produit(string nom, double prix)
        {
            Nom = nom;
            Prix = prix;
            Quantite = 0;
        }

        public void Afficher()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Prix : {Prix:F} $CAD");
            Console.WriteLine($"Quantité : {Quantite}");
            Console.WriteLine("=====================================");
        }

        public void AjouterStock(int quantite)
        {
            Quantite = Quantite + quantite;
        }

    }
}
