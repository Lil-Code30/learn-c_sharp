namespace stockManagement.classes
{
    internal class LigneTransaction
    {
        public Produit Produit { get; set; }
        public int Quantite { get; set; }

        public LigneTransaction(Produit produit, int quantite)
        {
            Produit = produit;
            Quantite = quantite;
        }
    }
}
