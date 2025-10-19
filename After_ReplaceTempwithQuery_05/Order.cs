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
        if (BasePrice() > 1000)
        {
            return BasePrice() * 0.95;
        }
        else
        {
            return BasePrice() * 0.98;
        }
    }
    // Refactor: Tách phần tính basePrice thành phương thức riêng
    public double BasePrice()
    {
        return quantity * itemPrice;
    }
}

