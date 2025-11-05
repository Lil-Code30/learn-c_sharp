using oop.classes;

class Employe
{
    private string nom;
    private string fonction;
    private int bureau;
    private string email;

    public Employe(string nom, string fonction, int bureau, string email)
    {
        this.nom = nom;
        this.fonction = fonction;
        this.email = email;
        if (bureau >= 1 && bureau <= 99)
        {
            this.bureau = bureau;
        }
    }

    public Employe(string nom, string fonction, string email)
    {
        this.nom = nom;
        this.fonction = fonction;
        this.email = email;
    }
    
    public int Bureau
    {
        set
        {
            if (value >= 1 && value <= 99)
            {
                bureau = value;
            }
        }
    }

    public void Afficher()
    {
        Console.WriteLine($"\n Le nom de l'employee est {nom} \n son E-mail est : {email}");
    }
    
    public bool Louer(Livre livre){
        if (!livre.EstLoue())
        {
            livre.Locataire = this;
            return true;
        }

        return false;
    }
}


class Livre
{
    private string titre;
    private string auteur;
    private string edition;
    private Employe locataire;

    public Livre(string titre, string auteur, string edition)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.edition = edition;
    }

    public Employe Locataire
    {
        set
        {
            locataire = value;
        }
    }

    public bool EstLoue()
    {
        if (locataire == null)
        {
            return false;
        }

        return true;
    }
}