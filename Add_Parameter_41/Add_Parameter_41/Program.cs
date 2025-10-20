using System;

class Invoice
{
    private double _taxRate = 0.1;

    public double CalculateTotal(double subtotal, double taxRate)
    {
        return subtotal + (subtotal * taxRate);
    }

    public void PrintTotal()
    {
        double subtotal = 200;
        double total = CalculateTotal(subtotal, _taxRate); // Gọi phương thức có 2 tham số
        Console.WriteLine("Total: " + total);
    }
}
