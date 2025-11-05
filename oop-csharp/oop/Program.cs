using oop.classes;

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        r1.longeur = 3;
        r1.largeur = 2;

        Console.WriteLine($"La Surface est : {r1.Surface()}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        List<Employe> employes = new List<Employe>
        {
            new Employe("Dupont", "Développeur", 15, "j.dupont@email.com"),
            new Employe("Martin", "Manager", 22, "p.martin@email.com"),
            new Employe("Durand", "Designer", "s.durand@email.com"),
            new Employe("Leroy", "Testeur", 45, "a.leroy@email.com"),
            new Employe("Moreau", "RH", "c.moreau@email.com")
        };
        
        List<Livre> livres = new List<Livre>();
        for (int i = 1; i <= 10; i++)
        {
            livres.Add(new Livre($"Le Livre de C# Vol. {i}", $"Auteur {i}", "Edition Tech"));
        }

        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║          BIENVENUE DANS LE SYSTÈME DE BIBLIO         ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════╝");

        Console.WriteLine("\n--- Liste des Employés ---");
        employes.ForEach(e => e.Afficher());

        Console.WriteLine("\n--- Liste des Livres ---");
        livres.ForEach(l => l.Afficher());
        
        // --- Simulate renting books ---
        Console.WriteLine("\n--- Simulation de Location ---");
        employes[0].Louer(livres[0]);
        Console.WriteLine($"Tentative de location: {employes[0].nom} loue '{livres[0].titre}'.");

        employes[2].Louer(livres[4]);
        Console.WriteLine($"Tentative de location: {employes[2].nom} loue '{livres[4].titre}'.");

        // --- Display Final Status ---
        Console.WriteLine("\n--- État Final des Livres ---");
        livres.ForEach(l => l.Afficher());
        
        
    }
}