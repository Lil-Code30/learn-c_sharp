using oop.classes;

class Program
{
    static void Main()
    {

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 MENU DE DÉMONSTRATION                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine("1. Démonstration de la classe Rectangle");
            Console.WriteLine("2. Démonstration du système de bibliothèque (Employe/Livre)");
            Console.WriteLine("3. Démonstration de la classe Montre");
            Console.WriteLine("4. Démonstration de la classe Person");
            Console.WriteLine("5. Démonstration de la classe Presentation");
            Console.WriteLine("6. Démonstration Casting");
            Console.WriteLine("0. Quitter");
            Console.Write("\nVotre choix : ");

            string choix = Console.ReadLine();
            
            Console.WriteLine();
            switch (choix)
            {
                case "1":
                    RunRectangleDemo();
                    break;
                case "2":
                    RunLibraryDemo();
                    break;
                case "3":
                    RunMontreDemo();
                    break;
                case "4":
                    RunPersonDemo();
                    break;
                case "5":
                    RunPresentationDemo();
                    break;
                case "6":
                    RunCastingDemo();
                    break;
                case "0":
                    exit = true;
                    Console.WriteLine("Au revoir !");
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;

            }
        }


        static void RunRectangleDemo()
        {
            Rectangle r1 = new Rectangle();
            
            Console.Write("Veuillez entrer la longueur : ");
            int longeur = Int16.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer la largeur : ");
            int largeur = Int16.Parse(Console.ReadLine());

            r1.longeur = longeur;
            r1.largeur = largeur;

            Console.WriteLine($"La Surface (longueur {longeur} et largeur: {largeur}) est : {r1.Surface()}");
        }
        

        static void RunLibraryDemo()
        {
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


            Console.WriteLine("\n--- Simulation de Location ---");
            employes[0].Louer(livres[0]);
            Console.WriteLine($"Tentative de location: {employes[0].nom} loue '{livres[0].titre}'.");

            employes[2].Louer(livres[4]);
            Console.WriteLine($"Tentative de location: {employes[2].nom} loue '{livres[4].titre}'.");


            Console.WriteLine("\n--- État Final des Livres ---");
            livres.ForEach(l => l.Afficher());

        }
        
        static void RunMontreDemo()
        {
            Console.WriteLine("===== eMontre Shop =======");

            /*
            Montre m = new Montre(19, 6, 14);

            Console.WriteLine($"\n{m.Heure} heure.");

            m.Minute = 90;
            Console.WriteLine($"minute : {m.Minute}"); // la minute serait tjr a 6 

            m.Seconde = 58;
            m.AfficherMontre();

            m = new Montre(22, 39, 44);

            Console.Write("Montre apres modification : ");
            m.AfficherMontre();

            Montre m2 = new Montre(m);
            m2.AfficherMontre();
            */

            Console.WriteLine();

            Montre[] montres = new Montre[5];

            Random rand = new Random();

            // Création d'une liste de 5 montres avec des données aléatoires valides
            for (int i = 0; i < 5; i++)
            {
                int heure = rand.Next(0, 24);
                int minute = rand.Next(0, 60);
                int seconde = rand.Next(0, 60);
                montres[i] = new Montre(heure, minute, seconde);
            }

            afficheListeMontre("montres", montres);

            Montre[] magasinA =
            {
                new Montre(10, 20, 30),
                new Montre(11, 22, 33),
                new Montre(12, 30, 45),
                new Montre(9, 15, 0),
                new Montre(23, 59, 59),
                new Montre(18, 5, 10),
                new Montre(6, 0, 0),
                new Montre(15, 45, 20)
            };

            afficheListeMontre("magasinA", magasinA);

            Console.WriteLine();
            Montre.AfficherNombreDeMontre();

            void afficheListeMontre(string nom, Montre[] montres)
            {
                Console.WriteLine($"\n=== Collection de Montres chez '{nom}' ===");
                Console.WriteLine("╔════════════╦══════════════════════╗");
                Console.WriteLine("║   Montre # ║      Heure Actuelle  ║");
                Console.WriteLine("╠════════════╬══════════════════════╣");

                int index = 1;

                foreach (var montre in montres)
                {
                    Console.Write($"║    {index,2}      ║ ");
                    montre.AfficherMontre();
                    index++;
                }
                Console.WriteLine("╚════════════╩══════════════════════╝");
                Console.WriteLine();
                Montre.AfficherNombreDeMontreDansUnMagasin(nom, montres);
                Console.WriteLine();
            }

        }
        
        static void RunPersonDemo()
        {
            // var person = new Person();
            // person.Name = "Loko";
            // person.Introduce("Isko");

            var person = Person.Parse("Loko");

            person.Introduce("Isko");

            person.Birthdate = new DateTime(2000, 1, 1);

            Console.WriteLine($"I am {person.Age} years old.");
        } 

        static void RunPresentationDemo()
        {
            var text = new Text();

            text.width = 100;
            text.Height = 50;

            text.Copy();

            Console.WriteLine("Logger demonstration...");

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }

        static void RunCastingDemo()
        {
            Paragraph p1 = new Paragraph();
            Shape shape = p1;  // upcasting going on here 

            p1.Width = 200;
            shape.Width = 100;

            Console.WriteLine(p1.Width);
        }
    }
}