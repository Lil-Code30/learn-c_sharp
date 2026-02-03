namespace gestion_de_fichier.classes;

class Person
{
    public string lastname;
    public string firstname;
    public string job;
    public int age;

    public Person(string lastname, string firstname, string job, int age)
    {
        this.lastname = lastname;
        this.firstname = firstname;
        this.job = job;
        this.age = age;
    }
    
    public void Afficher()
    {
        Console.WriteLine("+----------------+----------------+");
        Console.WriteLine("| Field          | Value          |");
        Console.WriteLine("+----------------+----------------+");
        Console.WriteLine($"| Last Name      | {lastname,-14} |");
        Console.WriteLine($"| First Name     | {firstname,-14} |");
        Console.WriteLine($"| Job            | {job,-14} |");
        Console.WriteLine($"| Age            | {age,-14} |");
        Console.WriteLine("+----------------+----------------+");
    }
}