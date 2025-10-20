using System;

namespace RefactoringExample
{
    class Person
    {
        // Biến private - ẩn đi khỏi bên ngoài
        private string name;

        // Cung cấp property công khai để truy cập an toàn
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            // Gọi setter (set)
            p.Name = "Alice";

            // Gọi getter (get)
            Console.WriteLine($"Tên: {p.Name}");
        }
    }
}
