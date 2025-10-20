using System;

namespace RefactoringExample
{
    class Employee
    {
        public static readonly int ENGINEER = 0;
        public static readonly int SALESMAN = 1;

        private string name;
        private int type;

        public Employee(string name, int type)
        {
            this.name = name;
            this.type = type;
        }

        public int GetTypeCode() => type;

        public double GetPayAmount()
        {
            switch (type)
            {
                case ENGINEER:
                    return 5000.0;
                case SALESMAN:
                    return 3000.0 + GetCommission();
                default:
                    throw new Exception("Invalid employee type");
            }
        }

        private double GetCommission() => 500.0;

        public override string ToString() => $"{name} ({GetRoleName()})";

        private string GetRoleName()
        {
            return type == ENGINEER ? "Engineer" : "Salesman";
        }
    }

    class Program
    {
        static void Main()
        {
            Employee e1 = new Employee("An", Employee.ENGINEER);
            Employee e2 = new Employee("Bình", Employee.SALESMAN);

            Console.WriteLine($"{e1}: {e1.GetPayAmount()}$");
            Console.WriteLine($"{e2}: {e2.GetPayAmount()}$");
        }
    }
}
