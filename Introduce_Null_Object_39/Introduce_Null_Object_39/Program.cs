using System;

abstract class Employee
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Employee(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public double CalculateBonus(double salary)
    {
        if (Type == "Manager")
            return salary * 0.2;
        else if (Type == "Developer")
            return salary * 0.1;
        else if (Type == "Tester")
            return salary * 0.05;
        else
            return 0;
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new EmployeeImpl("Alice", "Manager");
        Employee emp2 = new EmployeeImpl("Bob", "Developer");

        Console.WriteLine($"{emp1.Name} bonus: {emp1.CalculateBonus(1000)}");
        Console.WriteLine($"{emp2.Name} bonus: {emp2.CalculateBonus(1000)}");
    }
}

// Tạm để tạo đối tượng (vì lớp Employee là abstract)
class EmployeeImpl : Employee
{
    public EmployeeImpl(string name, string type) : base(name, type) { }
}
