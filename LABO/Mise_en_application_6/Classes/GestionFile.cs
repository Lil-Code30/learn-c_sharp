namespace Mise_en_application_6.Classes
{
    public class GestionFile
    {
        public static Queue<Commande> queueCommandes = new Queue<Commande>();

        public void GererCommandes(string action, Commande commande = null)
        {
            switch (action)
            {
                case "ajouter":
                    queueCommandes.Enqueue(commande);
                    Console.WriteLine("Commande traitée");
                    break;

                case "traiter":
                    if (queueCommandes.Count != 0)
                    { 
                        queueCommandes.Dequeue();
                        Console.WriteLine("Commande traitée");
                    }
                    else
                    {
                        Console.WriteLine("Aucune commande à traiter");
                    }
                    break;

                case "annuler":
                    if (queueCommandes.Count != 0)
                    {
                        foreach(Commande c in queueCommandes)
                        {
                            if(c.Code == commande.Code)
                            {
                                queueCommandes = new Queue<Commande>(queueCommandes.Where(c => c.Code != commande.Code));

                                Console.WriteLine("Commande annulée");
                            }
                            else
                            {
                                Console.WriteLine("Commande introuvable");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("File vide");
                    }
                    break;

                default:
                    Console.WriteLine("Action invalide");
                    break;

            }


            Console.WriteLine("Affichage des commandes en attente");
            Console.WriteLine("+" + new string('-', 65) + "+");
            Console.WriteLine($"| {"Code",-10} | {"TypePizza",-20} | {"Prix",-10} | {"Statut",-12} |");
            Console.WriteLine("+" + new string('-', 65) + "+");

            if (queueCommandes.Count == 0)
            {
                Console.WriteLine($"| {"[AUCUNE COMMANDE]",-63} |");
            }
            else
            {
                foreach (Commande c in queueCommandes)
                {
                    // Format Prix with 2 decimals and currency symbol
                    string prixFormatted = $"{c.Prix,10:F2} $";
                    Console.WriteLine($"| {c.Code,-10} | {c.TypePizza,-20} | {prixFormatted} | {c.Statut,-12} |");
                }
            }

            Console.WriteLine("+" + new string('-', 65) + "+");
            Console.WriteLine($"Total: {queueCommandes.Count} commande(s)");
        }
    }

    public class Commande
    {
        public string Code { get; set; }
        public string TypePizza { get; set; }
        public double Prix { get; set; }
        public string Statut { get; set; }
    }
}
