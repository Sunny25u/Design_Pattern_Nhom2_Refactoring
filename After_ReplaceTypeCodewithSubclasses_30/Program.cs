using System;

namespace RefactoringExample
{
    abstract class Employee
    {
        protected string name;

        protected Employee(string name)
        {
            this.name = name;
        }

        public abstract double GetPayAmount();

        public override string ToString() => $"{name} ({GetType().Name})";

        // Factory method: tạo Employee phù hợp với type code cũ
        public static Employee Create(string name, int type)
        {
            return type switch
            {
                0 => new Engineer(name),
                1 => new Salesman(name),
                _ => throw new ArgumentException("Invalid employee type")
            };
        }
    }

    class Engineer : Employee
    {
        public Engineer(string name) : base(name) { }

        public override double GetPayAmount() => 5000.0;
    }

    class Salesman : Employee
    {
        public Salesman(string name) : base(name) { }

        public override double GetPayAmount() => 3000.0 + GetCommission();

        private double GetCommission() => 500.0;
    }

    class Program
    {
        static void Main()
        {
            Employee e1 = Employee.Create("An", 0);
            Employee e2 = Employee.Create("Bình", 1);

            Console.WriteLine($"{e1}: {e1.GetPayAmount()}$");
            Console.WriteLine($"{e2}: {e2.GetPayAmount()}$");
        }
    }
}
