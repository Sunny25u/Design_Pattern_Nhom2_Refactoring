using System;
using System.Collections.Generic;

namespace RefactoringExample
{
    class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            order.Customer = this; // liên kết ngược
        }
    }

    class Order
    {
        public double Amount { get; set; }
        public Customer Customer { get; set; }

        public Order(double amount)
        {
            Amount = amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Alice");
            Order o1 = new Order(100);
            Order o2 = new Order(200);

            c.AddOrder(o1);
            c.AddOrder(o2);

            Console.WriteLine($"{c.Name} có {c.Orders.Count} đơn hàng.");
            Console.WriteLine($"Đơn hàng đầu tiên thuộc về: {o1.Customer.Name}");
        }
    }
}
