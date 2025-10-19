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
         double perimeter = 2 * (height + width); // Chu vi
        Console.WriteLine("Perimeter: " + perimeter);

         double area = height * width; // Diện tích
        Console.WriteLine("Area: " + area);
    }
}

