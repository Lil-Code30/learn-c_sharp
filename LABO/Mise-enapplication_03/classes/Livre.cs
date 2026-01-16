namespace Mise_enapplication_03.classes;

public class Livre
{
    private string title;
    private string auteur;
    private int edition;
    public Employe locataire;
    public bool disponible;

    public Livre(string title, string auteur, int edition)
    {
        this.title = title;
        this.auteur = auteur;
        this.edition = edition;
        this.disponible = true;
    }

    public void EstLoue()
    {
        if(this.locataire != null)
        {
            Console.WriteLine("Est Loué");
        }
        else
        {
            Console.WriteLine("Pas Loué");
        }
    }

    public void Afficher()
    {
        Console.WriteLine($"============ Livre : '{this.title}' =============");
        Console.WriteLine($"Par {this.auteur}");
        Console.WriteLine($"Edition : {this.edition}");
        Console.WriteLine($"Disponible : {this.disponible}");
        
        if (this.locataire != null)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Locataire  ");

            this.locataire.Afficher();
        }

        Console.WriteLine("==================================================");
    }
    
}