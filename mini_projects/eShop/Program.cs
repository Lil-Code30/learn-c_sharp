using eShop.Classes;

class Programm
{
    static void Main()
    {
        var c1 = new Customer("Alice");
        var c2 = new Customer("Loko");

        c2.PassOrder(34);
        c2.PassOrder(32);
        c2.PassOrder(33);



        Customer.DispalyTotalCustomers();

        foreach (var ord in c2.CustomerOrders) Console.WriteLine("  " + ord);

        Console.WriteLine($"{c2.Name} has {c2.CustomersTotalOrder()} total orders on eShop.");
    }
}