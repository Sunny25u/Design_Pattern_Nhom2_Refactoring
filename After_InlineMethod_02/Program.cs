using System;

class PizzaDelivery
{
    private int numberOfLateDeliveries;

    public PizzaDelivery(int lateDeliveries)
    {
        numberOfLateDeliveries = lateDeliveries;
    }

    int GetRating()
    {
        // Inline the logic directly instead of calling a separate method
        return numberOfLateDeliveries > 5 ? 2 : 1;
    }
    public void PrintRating()
    {
        Console.WriteLine("Rating: " + GetRating());
    }
}
class Program
{
    static void Main()
    {
        PizzaDelivery pizza1 = new PizzaDelivery(3);
        PizzaDelivery pizza2 = new PizzaDelivery(7);
        pizza1.PrintRating();
        pizza2.PrintRating();
    }
}
