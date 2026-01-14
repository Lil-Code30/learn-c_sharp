namespace eShop.Classes;

class Customer
{
    public int Id { get; }
    public string Name { get; set; }
    public readonly List<Order> CustomerOrders = new List<Order>();

    private static int _totalCustomers = 0;
    
    public Customer( string name)
    {
        this.Id = ++_totalCustomers;
        this.Name = name;
        
    }

    public void PassOrder(float total)
    {
        Order order = new Order(Id, total);

        Order.AddOrderToHistoryList(order);
        CustomerOrders.Add(order);
    }
    
    public int CustomersTotalOrder()
    {
        return CustomerOrders.Count;
    }
    
    public static void DispalyTotalCustomers()
    {
        Console.WriteLine($"Total Customers of eShop : {_totalCustomers} customers.");
    }
}