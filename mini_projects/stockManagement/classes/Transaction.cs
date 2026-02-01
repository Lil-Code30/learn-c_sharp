namespace stockManagement.classes
{
    internal class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LigneTransaction> Lignes { get; set; }

        public Transaction(int id)
        {
            Id = id;
            Date = DateTime.Now;
            Lignes = new List<LigneTransaction>();
        }

        public void AjouterLigne(Produit produit, int quantite)
        {
            Lignes.Add(new LigneTransaction(produit, quantite));
            produit.Stock -= quantite;
        }
    }
}
