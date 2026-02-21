using Mise_en_application_6.Classes;
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
                        Exercice02_GestionFile.Executer();
                        break;

                    case "3":
                        // Exercice03_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 3 non encore implémenté");
                        break;
                    case "4":
                        Console.WriteLine("Enter the string to reverse: ");
                        string str = Console.ReadLine();
                        string reversString = InverserChaine.Inverser_Chaine(str);
                        Console.WriteLine(reversString);
                        break;

                    case "5":
                        Console.WriteLine("Enter the Phrase to verify: ");
                        string phrase = Console.ReadLine();
                        bool result = VerificationParentheses.VerifParentheses(phrase);
                        Console.WriteLine(result);
                        break;

                    case "6":
                        // Exercice06_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 6 non encore implémenté");
                        break;

                    case "7":
                        // Exercice06_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 7 non encore implémenté");
                        break;

                    case "8":
                        // Exercice06_XXXX.Executer()
                        Console.WriteLine("⚠️ Exercice 8 non encore implémenté");
                        break;

                    case "9":
                        // Exercice06_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 9 non encore implémenté");
                        break;

                    case "10":
                        // Exercice06_XXXX.Executer();
                        Console.WriteLine("⚠️ Exercice 10 non encore implémenté");
                        break;

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
            Console.WriteLine("  1️  Gestion d’une pile de dossiers d’assurance");
            Console.WriteLine("  2️  Gestion des commandes d’une pizzeria (file d’attente)");
            Console.WriteLine("  3️  Construction et parcours d’un arbre binaire ");
            Console.WriteLine("  4️  Inversion d’une chaîne avec une pile ");
            Console.WriteLine("  5️  Vérification de parenthèses équilibrées (pile)");
            Console.WriteLine("  6️  Gestion de l'historique des actions (Undo/Redo) avec une pile");
            Console.WriteLine("  7️  Simulation d’une file d’attente dans une banque (file) ");
            Console.WriteLine("  8️  Calcul de la profondeur d’un arbre binaire ");
            Console.WriteLine("  9️  Fusion de deux listes triées (listes chaînées)");
            Console.WriteLine("  10 Recherche d’un élément dans un arbre binaire ");
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