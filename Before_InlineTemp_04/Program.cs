using System;

class Program
{
    static void Main()
    {
        Order order1 = new Order(1200);
        Order order2 = new Order(800);
        Console.WriteLine("Order 1 has discount? " + HasDiscount(order1));
        Console.WriteLine("Order 2 has discount? " + HasDiscount(order2));
    }

    // Có sử dụng biến tạm basePrice
    static bool HasDiscount(Order order)
    {
        double basePrice = order.BasePrice();
        return basePrice > 1000;
    }
}
