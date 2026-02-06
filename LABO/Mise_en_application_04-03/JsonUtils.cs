using Mise_en_application_04_03.classes;
using Newtonsoft.Json;
namespace Mise_en_application_04_03;



public class JsonUtils
{
    
    // D’importer des données depuis un fichier JSON.
    public static void Import(string filePath)
    {
        
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"The file {filePath} does not exist.");
            return;
        }

        string jsonContent = File.ReadAllText(filePath);
        
        List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(jsonContent);
        
        // display employee 
        PrintTable(employees);
    }
    
    // D’exporter une liste d’objets en fichier JSON.
    public static void Export(string filePath, List<Employee> data)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"The file {filePath} does not exist.");
            return;
        }
        
        string output = JsonConvert.SerializeObject(data, Formatting.Indented);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(output);
        }
        
        PrintTable(data);
    }
    
    // De modifier et mettre à jour un fichier JSON existant.
    public static void Modify(string filePath, Employee employee)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"The file {filePath} does not exist.");
            return;
        }

        string fileContent = File.ReadAllText(filePath);
        List<Employee> employeeListToModify = JsonConvert.DeserializeObject<List<Employee>>(fileContent);

        
        employeeListToModify.Add(employee);
        
        PrintTable(employeeListToModify);
    }
    
    private static void PrintTable(List<Employee> employees)
    {
        if (employees == null || employees.Count == 0)
        {
            Console.WriteLine("No data to display.");
            return;
        }

        // Column widths
        int nomWidth = 15;
        int prenomWidth = 15;
        int fonctionWidth = 25;
        int entrepriseWidth = 15;

        // Header
        Console.WriteLine(
            $"{ "Nom".PadRight(nomWidth) }" +
            $"{ "Prénom".PadRight(prenomWidth) }" +
            $"{ "Fonction".PadRight(fonctionWidth) }" +
            $"{ "Entreprise".PadRight(entrepriseWidth) }"
        );

        Console.WriteLine(new string('-', nomWidth + prenomWidth + fonctionWidth + entrepriseWidth));

        // Rows
        foreach (var employee in employees)
        {
            Console.WriteLine(
                $"{ employee.nom.PadRight(nomWidth) }" +
                $"{ employee.prenom.PadRight(prenomWidth) }" +
                $"{ employee.fonction.PadRight(fonctionWidth) }" +
                $"{ employee.entreprise.PadRight(entrepriseWidth) }"
            );
        }
    }

}