using System;

public class Order
{
    private double basePrice;

    public Order(double basePrice)
    {
        this.basePrice = basePrice;
    }

    public double BasePrice()
    {
        return basePrice;
    }
}
