namespace Mise_en_application_04_03.classes;

public class Employee
{
    public string nom { get; set; }
    public string prenom { get; set; }
    public string fonction { get; set; }
    public string entreprise { get; set; }

    public Employee(string nom, string prenom, string fonction, string entreprise)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.fonction = fonction;
        this.entreprise = entreprise;
    }
    
    public static Employee CreateEmployeeFromInput()
    {
        Console.Clear();
        Console.WriteLine("Add Employee");
        Console.WriteLine("------------------------");

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Position: ");
        string position = Console.ReadLine();

        Console.Write("Company: ");
        string company = Console.ReadLine();

        return new Employee(lastName, firstName, position, company);
    }
    
}