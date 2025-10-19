using System;

class Program
{
    static void Main()
    {
        Order order1 = new Order(120, 10);
        Order order2 = new Order(80, 10);
        Console.WriteLine("Order 1 total: " + order1.CalculateTotal());
        Console.WriteLine("Order 2 total: " + order2.CalculateTotal());
    }
}

