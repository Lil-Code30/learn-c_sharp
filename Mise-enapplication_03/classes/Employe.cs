namespace Mise_enapplication_03.classes;

public class Employe
{
    protected string nom;
    protected string fonction;
    protected int bureau;
    protected string email;

    public Employe(string nom, string fonction, int bureau, string email)
    {
        this.nom = nom;
        this.fonction = fonction;
        this.bureau = bureau;
        this.email = email;
    }

    public void Afficher()
    {
        Console.WriteLine("================= Carte Employe ==========");
        Console.WriteLine($"Nom : {this.nom}");
        Console.WriteLine($"Fonction : {this.fonction}");
        Console.WriteLine($"Bureau N0 : {this.bureau}");
        Console.WriteLine($"Email : {this.email}");
        Console.WriteLine("==========================================");
    }

    public void Louer(Livre livre)
    {
        livre.locataire = this;
        livre.disponible = false;
        Console.WriteLine("Livre");
    }    
    
}