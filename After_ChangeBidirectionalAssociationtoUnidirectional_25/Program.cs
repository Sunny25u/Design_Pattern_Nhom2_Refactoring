using System;

namespace RefactoringExample
{
    class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
    }

    class Order
    {
        public double Amount { get; set; }
        public Customer Customer { get; set; }

        public Order(double amount, Customer customer)
        {
            Amount = amount;
            Customer = customer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Alice");
            Order o1 = new Order(100, c);
            Order o2 = new Order(200, c);

            Console.WriteLine($"Đơn hàng đầu tiên thuộc về: {o1.Customer.Name}");
        }
    }
}
