using Before_ChangeReferenceToValue_19;

class Program
{
    static void Main(string[] args)
    {
        Currency currency1 = new Currency("USD");
        Currency currency2 = currency1; // Ca hai cung tham chieu den 1 object

        Console.WriteLine("Truoc khi thay doi:");
        Console.WriteLine($"currency1: {currency1}");
        Console.WriteLine($"currency2: {currency2}");

        // Thay doi tu currency2 anh huong den currency1
        currency2.Code = "EUR";

        Console.WriteLine("\nSau khi thay doi:");
        Console.WriteLine($"currency1: {currency1}");
        Console.WriteLine($"currency2: {currency2}");
    }
}