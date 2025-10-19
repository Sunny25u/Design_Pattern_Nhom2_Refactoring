using After_ChangeReferenceToValue_19;

class Program
{
    static void Main(string[] args)
    {
        Currency currency1 = new Currency("USD");
        Currency currency2 = new Currency("USD"); // Tao moi, khong anh huong nhau

        Console.WriteLine("So sanh gia tri:");
        Console.WriteLine($"currency1.Equals(currency2) => {currency1.Equals(currency2)}");

        Console.WriteLine("\nDoi tuong sau khi khoi tao:");
        Console.WriteLine($"currency1: {currency1}");
        Console.WriteLine($"currency2: {currency2}");
    }
}