namespace stockManagement.classes
{
    internal class Magasin
    {
        public string Nom { get; set; }

        // AGRÉGATION
        public List<Produit> Produits { get; set; }

        // COMPOSITION
        public List<Transaction> Transactions { get; set; }

        public Magasin(string nom)
        {
            Nom = nom;
            Produits = new List<Produit>();
            Transactions = new List<Transaction>();
        }

        public void AjouterProduit(Produit produit)
        {
            Produits.Add(produit);
        }

        public void AjouterTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public void AfficherStock()
        {
            Console.WriteLine("\n📦 STOCK ACTUEL");
            foreach (var p in Produits)
            {
                Console.WriteLine($"- {p.Nom} : {p.Stock} unités");
            }
        }

        public void AfficherTransactions()
        {
            Console.WriteLine("\n🧾 TRANSACTIONS");
            foreach (var t in Transactions)
            {
                Console.WriteLine($"\nTransaction #{t.Id} - {t.Date}");
                foreach (var l in t.Lignes)
                {
                    Console.WriteLine($"   {l.Produit.Nom} x {l.Quantite}");
                }
            }
        }
    }
}
