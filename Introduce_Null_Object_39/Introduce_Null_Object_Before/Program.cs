using System;

abstract class Employee
{
    public string Name { get; set; }
    public Employee(string name) => Name = name;

    public abstract double CalculateBonus(double salary); // ✅ hành vi riêng từng loại
}

class Manager : Employee
{
    public Manager(string name) : base(name) { }
    public override double CalculateBonus(double salary) => salary * 0.2;
}

class Developer : Employee
{
    public Developer(string name) : base(name) { }
    public override double CalculateBonus(double salary) => salary * 0.1;
}

class Tester : Employee
{
    public Tester(string name) : base(name) { }
    public override double CalculateBonus(double salary) => salary * 0.05;
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Manager("Alice");
        Employee emp2 = new Developer("Bob");
        Employee emp3 = new Tester("Charlie");

        Console.WriteLine($"{emp1.Name} bonus: {emp1.CalculateBonus(1000)}");
        Console.WriteLine($"{emp2.Name} bonus: {emp2.CalculateBonus(1000)}");
        Console.WriteLine($"{emp3.Name} bonus: {emp3.CalculateBonus(1000)}");
    }
}
