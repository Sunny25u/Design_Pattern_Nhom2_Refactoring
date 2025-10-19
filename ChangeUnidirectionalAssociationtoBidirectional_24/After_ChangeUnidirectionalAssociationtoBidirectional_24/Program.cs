using After_ChangeUnidirectionalAssociationtoBidirectional_24;
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Alice");
        Order order1 = new Order(customer);
        Order order2 = new Order(customer);

        Console.WriteLine("Orders of customer " + customer.Name + ":");
        foreach (Order o in customer.GetOrders())
        {
            Console.WriteLine("- Order instance: " + o.GetHashCode());
        }

        Console.ReadKey();
    }
}