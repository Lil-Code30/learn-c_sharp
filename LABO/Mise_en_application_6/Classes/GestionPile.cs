namespace Mise_en_application_6.Classes;

public class GestionPile
{
    public static Stack<DossierAssurance> PileDossiers = new Stack<DossierAssurance>();

    public void GererPileDossiers(string action, DossierAssurance dossier = null)
    {
        switch (action)
        {
            case "ajouter":
                PileDossiers.Push(dossier);
                Console.WriteLine("Dossier ajouté");
                break;
            case "consulter":
                if(PileDossiers.Count != 0)
                {
                    Console.WriteLine($"→ Dossier au sommet: {PileDossiers.Peek().Code}");
                }
                else
                {
                   Console.WriteLine("Pile vide");
                }
                break;
            case "retirer":               
                if (PileDossiers.Count != 0)
                {
                    PileDossiers.Pop();
                    Console.WriteLine("Dossier  retiré");
                }
                else
                {
                    Console.WriteLine("Pile vide");
                }
                break;
            default:
                Console.WriteLine("Action invalide");
                break;
               
        }

        Console.WriteLine("L'état actuel de la pile");
        Console.WriteLine("+" + new string('-', 60) + "+");
        Console.WriteLine($"| {"Code",-10} | {"Requerant",-15} | {"Type",-10} | {"Statut",-10} |");
        Console.WriteLine("+" + new string('-', 60) + "+");

        if(PileDossiers.Count == 0)
        {
            Console.WriteLine($"| {"[PILE VIDE]"} |");
        }
        else
        {
            foreach (DossierAssurance d in PileDossiers)
            {
                Console.WriteLine($"| {d.Code,-10} | {d.Requerant,-15} | {d.Type,-10} | {d.Statut,-10} |");
            }
        } 

        Console.WriteLine("+" + new string('-', 60) + "+");
        Console.WriteLine($"Total: {PileDossiers.Count} dossier(s)");
    }
    
}


public class DossierAssurance
{
    public string Code { get; set; }
    public string Requerant { get; set; }
    public string Type { get; set; }
    public string Statut { get; set; }

    public DossierAssurance(string code, string requerant, string type, string statut)
    {
        Code = code;
        Requerant = requerant;
        Type = type;
        Statut = statut;
    }


}

