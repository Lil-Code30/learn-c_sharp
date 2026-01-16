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
        
    }

    public void Louer(Livre livre)
    {
        
    }    
    
}