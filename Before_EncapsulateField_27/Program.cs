using System;

namespace RefactoringExample
{
    class Person
    {
        // Biến công khai (public field)
        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Alice"; // Truy cập trực tiếp
            Console.WriteLine($"Tên: {p.name}");
        }
    }
}
