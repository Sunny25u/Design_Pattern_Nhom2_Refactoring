using System;

abstract class Customer
{
    public abstract string GetGreeting();
}

class RealCustomer : Customer
{
    private string name;
    public RealCustomer(string name) => this.name = name;

    public override string GetGreeting() => $"Welcome, {name}!";
}

class NullCustomer : Customer
{
    public override string GetGreeting() => "Welcome, Guest!"; // ✅ hành vi mặc định
}

class Program
{
    static void Main()
    {
        Customer customer = GetCustomer(1);
        Console.WriteLine(customer.GetGreeting()); // không cần if-check
    }

    static Customer GetCustomer(int id)
    {
        // Giả lập: Không tìm thấy khách hàng
        return new NullCustomer(); // ✅ thay vì null
    }
}

