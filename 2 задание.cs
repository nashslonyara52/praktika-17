using System;

public class Order
{
    public int Id { get; set; }
    public decimal Total { get; set; }

    public override string ToString()
    {
        return $"Order {Id}: {Total:C}";
    }
}
class Program
{
    static void Main()
    {
        var order1 = new Order { Id = 1001, Total = 1500.50m };
        var order2 = order1;
        order2.Total = 2000.00m;
        Console.WriteLine(order1.Total);
    }
}