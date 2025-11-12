namespace oop.classes;

class Employe
{
    public string nom;
    protected string fonction;
    protected int bureau;
    public string email;

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
        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine($"│ Employé: {nom,-29} │");
        Console.WriteLine($"│ Fonction: {fonction,-28} │");
        Console.WriteLine($"│ Bureau: {(bureau == 0 ? "N/A" : bureau.ToString()),-30} │");
        Console.WriteLine($"│ E-mail: {email,-30} │");
        Console.WriteLine("└──────────────────────────────────────────┘");
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

class Bibliothecaire : Employe
{
    public Bibliothecaire(string nom, string fonction, string email) : base(nom, fonction, email)
    {

    }
    
    public void Retour(Livre livre)
    {
        livre.Locataire = null;
    }
}

class Livre
{
    public string titre;
    public string auteur;
    public string edition;
    public Employe locataire;

    public Livre(string titre, string auteur, string edition)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.edition = edition;
    }

    public Employe Locataire
    {
        get { return locataire; }
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

    public void Afficher()
    {
        Console.WriteLine("├──────────────────────────────────────────────────────┤");
        Console.WriteLine($"│ Titre: {titre,-49} │");
        Console.WriteLine($"│ Auteur: {auteur,-48} │");
        Console.WriteLine($"│ Loué: {(EstLoue() ? $"Oui, par {locataire.nom}" : "Non"),-50} │");
        Console.WriteLine("├──────────────────────────────────────────────────────┤");
    }
}