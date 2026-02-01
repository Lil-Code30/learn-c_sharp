namespace stockManagement.classes
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Stock { get; set; }

        public Produit(int id, string nom, int stock)
        {
            Id = id;
            Nom = nom;
            Stock = stock;
        }
    }
}
