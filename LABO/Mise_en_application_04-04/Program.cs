using Mise_en_application_04_04;
using Spectre.Console;
using Mise_en_application_04_04.models;
class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        List<Employee> employeesList = new List<Employee>
        {
            new Employee("Deschênes",
                "Philippe",
                "Ingénieur IT",
                "CGI"),
            new Employee
            (
                "Desjardins",
                "Catherine",
                "Responsable RH",
                "Desjardins"
            ),
            new Employee
            (
                "Leduc",
                "Vincent",
                "Analyste Data",
                "CGI"
            ),
            new Employee
            (
                "Tremblay",
                "Julie",
                "Chef de projet",
                "Desjardins"
            ),
            new Employee
            (
                "Fortin",
                "Hugo",
                "Développeur Web",
                "Desjardins"
            )
        };
        
        List<Student> students = new List<Student>
        {
            new Student("Dupont", "Jean", 20, "Licence", "Informatique", "Université de Montréal"),
            new Student("Martin", "Sarah", 22, "Licence", "Génie logiciel", "UQAM"),
            new Student("Nguyen", "Linh", 21, "Licence", "Systèmes informatiques", "Université Laval"),
            new Student("Diallo", "Amadou", 23, "Master", "Data Science", "Université de Sherbrooke"),
            new Student("Benali", "Yasmine", 24, "Master", "Intelligence Artificielle", "Polytechnique Montréal"),
            new Student("Smith", "Alex", 19, "Licence", "Informatique", "Concordia University"),
            new Student("Tremblay", "Lucas", 22, "Licence", "Cybersécurité", "Université du Québec à Rimouski"),
            new Student("Haddad", "Nour", 25, "Master", "Réseaux", "Université de Montréal"),
            new Student("Kone", "Fatou", 21, "Licence", "Développement Web", "UQTR"),
            new Student("Moreau", "Antoine", 26, "Doctorat", "Génie logiciel", "Université Laval")
        };
        
        while (running)
        {
            AnsiConsole.Clear();

            AnsiConsole.MarkupLine("[bold blue]📂 Gestionnaire CSV / JSON[/]");
            AnsiConsole.WriteLine();

            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choisissez une option :")
                    .PageSize(10)
                    .AddChoices(new[]
                    {
                        "Importer un fichier CSV",
                        "Exporter en CSV",
                        "Importer un fichier JSON",
                        "Exporter en JSON",
                        "Convertir CSV → JSON",
                        "Convertir JSON → CSV",
                        "Quitter"
                    }));

            switch (choice)
            {
                case "Importer un fichier CSV":
                    string csvFilePath = AnsiConsole.Prompt(
                        new TextPrompt<string>("The path to the CSV file: ")
                    );
                    
                    AnsiConsole.MarkupLine("[green]Importation CSV en cours...[/]");
                    
                    FileManager.ImportCSV(csvFilePath);
                    break;

                case "Exporter en CSV":
                    string filePath = AnsiConsole.Prompt(
                        new TextPrompt<string>("The path to the CSV file: ")
                    );
                    
                    AnsiConsole.MarkupLine("[green]Exportation CSV en cours...[/]");
                    
                    FileManager.ExportCSV(filePath, employeesList);
                    break;

                case "Importer un fichier JSON":
                    AnsiConsole.MarkupLine("[green]Importation JSON en cours...[/]");
                    // ImportJSON();
                    break;

                case "Exporter en JSON":
                    AnsiConsole.MarkupLine("[green]Exportation JSON en cours...[/]");
                    // ExportJSON();
                    break;

                case "Convertir CSV → JSON":
                    AnsiConsole.MarkupLine("[yellow]Conversion CSV → JSON en cours...[/]");
                    // ConvertCSVtoJSON();
                    break;

                case "Convertir JSON → CSV":
                    AnsiConsole.MarkupLine("[yellow]Conversion JSON → CSV en cours...[/]");
                    // ConvertJSONtoCSV();
                    break;

                case "Quitter":
                    running = false;
                    break;
            }

            if (running)
            {
                AnsiConsole.MarkupLine("\n[grey]Appuyez sur une touche pour continuer...[/]");
                Console.ReadKey();
            }
        }
    }
}