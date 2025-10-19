using Before_ChangeUnidirectionalAssociationtoBidirectional_24;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Alice");
        Order order = new Order(customer);

        Console.WriteLine(order.GetCustomer().Name); 
        // Nhưng không thể biết từ Customer rằng có Order nào -> Bị hạn chế
        Console.ReadKey();
    }
}