namespace Before_SelfEncapsulateField_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range(10, 20);
            range.PrintRange();

            Console.WriteLine("Check number 15: " + (range.Includes(15) ? "Inside Range" : "Outside Range"));
            Console.WriteLine("Check number 25: " + (range.Includes(25) ? "Inside Range" : "Outside Range"));

            Console.ReadKey();
        }
    }
}