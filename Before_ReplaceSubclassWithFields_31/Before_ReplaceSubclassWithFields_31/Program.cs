using System;

namespace Problem_TypeCodeWithState
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(Employee.ENGINEER);
            Console.WriteLine("Bonus as Engineer: " + employee.GetBonus());

            employee.Type = Employee.MANAGER; // Thay đổi loại khi đang chạy
            Console.WriteLine("Bonus as Manager: " + employee.GetBonus());
        }
    }
    class Employee
    {
        public const int ENGINEER = 0;
        public const int MANAGER = 1;
        public int Type { get; set; }
        public Employee(int type) { Type = type; }
        public double GetBonus()
        {
            switch (Type)
            {
                case ENGINEER: return 100;
                case MANAGER: return 200;
                default: return 0;
            }
        }
    }
}
