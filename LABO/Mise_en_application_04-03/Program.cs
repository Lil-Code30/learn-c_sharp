using Mise_en_application_04_03;
using Mise_en_application_04_03.classes;

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

bool running = true;

while (running)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("======================================");
    Console.WriteLine("   EMPLOYEE MANAGEMENT SYSTEM");
    Console.WriteLine("======================================");
    Console.ResetColor();
    
    Console.WriteLine("[1]  Export employees from a List to JSON");
    Console.WriteLine("[2]  Import employees from JSON to a Table");
    Console.WriteLine("[3]  Add new employee");
    Console.WriteLine("[0]  Exit");
    Console.WriteLine("--------------------------------------");
    Console.Write("👉 Choose an option: ");
    
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            JsonUtils.Export("employee.json", employeesList);
            Console.WriteLine("+---------++---------++---------++---------++---------+");
            Console.WriteLine("Employees exported successfully");
            break;

        case "2":
            JsonUtils.Import("employee.json");
            Console.WriteLine("+---------++---------++---------++---------++---------+");
            Console.WriteLine("Employees imported successfully");
            break;

        case "3":
            Employee newEmployee = Employee.CreateEmployeeFromInput();
            JsonUtils.Modify("employee.json", newEmployee);
            Console.WriteLine("+---------++---------++---------++---------++---------+");
            Console.WriteLine("Employee added/updated successfully");
            break;

        case "0":
            running = false;
            Console.WriteLine("+---------++---------++---------++---------++---------+");
            Console.WriteLine("👋 Goodbye!");
            break;

        default:
            Console.WriteLine("+---------++---------++---------++---------++---------+");
            Console.WriteLine("Error!! Invalid option. Try again.");
            running = false;
            break;
    }

}
