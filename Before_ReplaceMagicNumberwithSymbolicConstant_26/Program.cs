using System;

namespace RefactoringExample
{
    class Program
    {
        static double PotentialEnergy(double mass, double height)
        {
            // 9.81 là số ma thuật (acceleration due to gravity)
            return mass * height * 9.81;
        }

        static void Main(string[] args)
        {
            double m = 10;     // khối lượng (kg)
            double h = 5;      // độ cao (m)
            double energy = PotentialEnergy(m, h);

            Console.WriteLine($"Thế năng là: {energy} Joules");
        }
    }
}
