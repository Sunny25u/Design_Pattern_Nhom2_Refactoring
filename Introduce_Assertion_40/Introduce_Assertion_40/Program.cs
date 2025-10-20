using System;

class Customer
{
    public string Name { get; set; }
    public Customer(string name)
    {
        Name = name;
    }

    public string GetGreeting()
    {
        return $"Welcome, {Name}!";
    }
}

class Program
{
    static void Main()
    {
        Customer customer = GetCustomer(1);

        if (customer != null)
            Console.WriteLine(customer.GetGreeting());
        else
            Console.WriteLine("Welcome, Guest!");
    }

    static Customer GetCustomer(int id)
    {
        // Giả lập: Không tìm thấy khách hàng
        return null;
    }
}
