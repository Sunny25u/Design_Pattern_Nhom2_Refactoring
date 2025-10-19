using System;
class Customer
{
    private string name;
    private double amount;

    public Customer(string name, double amount)
    {
        this.name = name;
        this.amount = amount;
    }
    void PrintBanner()
    {
        Console.WriteLine("Customer Owes");
    }

    double GetOutstanding()
    {
        return this.amount;
    }
    public void PrintOwing()
    {
        this.PrintBanner();

        // Print details.
        Console.WriteLine("name: " + this.name);
        Console.WriteLine("amount: " + this.GetOutstanding());
    }
}