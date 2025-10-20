using System;

namespace RefactoringExample
{
    class Program
    {
        // Thay số 9.81 bằng một hằng số có tên rõ ràng
        const double GRAVITATIONAL_CONSTANT = 9.81;

        static double PotentialEnergy(double mass, double height)
        {
            return mass * height * GRAVITATIONAL_CONSTANT;
        }

        static void Main(string[] args)
        {
            double m = 10;  // kg
            double h = 5;   // m
            double energy = PotentialEnergy(m, h);

            Console.WriteLine($"Thế năng là: {energy} Joules");
        }
    }
}
