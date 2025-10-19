using System;

public class RectangleCalculator
{
    private double height;
    private double width;

    public RectangleCalculator(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    public void Calculate()
    {
        double temp = 2 * (height + width); // Tính chu vi
        Console.WriteLine("Perimeter: " + temp);

        temp = height * width; // Tính diện tích
        Console.WriteLine("Area: " + temp);
    }
}

