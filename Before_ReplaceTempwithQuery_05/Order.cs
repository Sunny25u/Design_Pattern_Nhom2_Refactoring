using System;
public class Order
{
    private int quantity;
    private double itemPrice;

    public Order(int quantity, double itemPrice)
    {
        this.quantity = quantity;
        this.itemPrice = itemPrice;
    }
    public double CalculateTotal()
    {
        double basePrice = quantity * itemPrice;

        if (basePrice > 1000)
        {
            return basePrice * 0.95;
        }
        else
        {
            return basePrice * 0.98;
        }
    }
}

