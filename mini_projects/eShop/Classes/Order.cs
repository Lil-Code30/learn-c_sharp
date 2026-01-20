namespace eShop.Classes;

public class Order
{
    public long Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public float Total { get; set; }
    public static readonly List<Order> Orders = new List<Order>();

    private static long _seedOrderId = 12345567890;
    public override string ToString()
    {
        return $"Order {Id} (Customer {CustomerId}) - {OrderDate:yyyy-MM-dd} - Total: {Total:C}";
    }

    public Order(int customerId, float total)
    {
        Id = _seedOrderId;
        CustomerId = customerId;
        OrderDate = DateTime.Now;
        Total = total;
    }
    public static void AddOrderToHistoryList(Order order)
    {
        Orders.Add(order);
        _seedOrderId++;
    }
}