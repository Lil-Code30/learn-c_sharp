using Mise_en_application_6.Exercices;

namespace Mise_en_application_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine()?.Trim();

                switch (choix)
                {
                    case "1":
                        Exercice01_GestionPile.Executer();
                        break;
                    case "2":
                        // Exercice02_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 2 non encore implémenté");
                        break;
                    case "3":
                        // Exercice03_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 3 non encore implémenté");
                        break;
                    // ... Ajouter les cas pour les exercices 4 à 10
                    case "0":
                        Console.WriteLine("\n👋 Merci d'avoir utilisé le programme. Au revoir !");
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("\n❌ Choix invalide. Veuillez sélectionner une option entre 0 et 10.\n");
                        break;
                }

                if (continuer)
                {
                    Console.WriteLine("\n" + new string('=', 50));
                    Console.WriteLine("Appuyez sur une touche pour revenir au menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine("╔" + new string('═', 48) + "╗");
            Console.WriteLine("║" + "MENU PRINCIPAL - MIS EN APPLICATION".Center(48) + "║");
            Console.WriteLine("╚" + new string('═', 48) + "╝\n");

            Console.WriteLine("📚 LISTE DES EXERCICES :");
            Console.WriteLine("─".PadRight(50, '─'));
            Console.WriteLine("  1️  Gestion d'une pile de dossiers d'assurance");
            Console.WriteLine("  2️  [Nom de l'exercice 2]");
            Console.WriteLine("  3️  [Nom de l'exercice 3]");
            Console.WriteLine("  4️  [Nom de l'exercice 4]");
            Console.WriteLine("  5️  [Nom de l'exercice 5]");
            Console.WriteLine("  6️  [Nom de l'exercice 6]");
            Console.WriteLine("  7️  [Nom de l'exercice 7]");
            Console.WriteLine("  8️  [Nom de l'exercice 8]");
            Console.WriteLine("  9️  [Nom de l'exercice 9]");
            Console.WriteLine("  10 [Nom de l'exercice 10]");
            Console.WriteLine("─".PadRight(50, '─'));
            Console.WriteLine("  0️  Quitter le programme\n");

            Console.Write("👉 Votre choix : ");
        }
    }

    // Extension utile pour centrer le texte dans le menu
    public static class StringExtensions
    {
        public static string Center(this string text, int width)
        {
            if (string.IsNullOrEmpty(text) || width <= text.Length)
                return text?.PadRight(width) ?? string.Empty;

            int padding = width - text.Length;
            int leftPad = padding / 2;
            return text.PadLeft(leftPad + text.Length).PadRight(width);
        }
    }
}