using System;

class Invoice
{
    private double _taxRate = 0.1;

    // ✅ Bỏ tham số taxRate vì có thể lấy từ class
    public double CalculateTotal(double subtotal)
    {
        return subtotal + (subtotal * _taxRate);
    }

    public void PrintTotal()
    {
        double subtotal = 200;
        double total = CalculateTotal(subtotal); // ✅ Gọi đơn giản hơn
        Console.WriteLine("Total: " + total);
    }
}

