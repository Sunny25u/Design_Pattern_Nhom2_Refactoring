using System;

namespace InlineClass_After
{
    class Program
    {
        static void Main(string[] args)
        {
            // ✅ Không cần lớp Address nữa
            Person person = new Person("Nguyen Van A", "123 Đường ABC", "TP.HCM");

            person.DisplayInfo();
        }
    }

    // ✅ Gộp thuộc tính và hành vi của Address vào Person
    class Person
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Person(string name, string street, string city)
        {
            Name = name;
            Street = street;
            City = city;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Họ tên: {Name}");
            Console.WriteLine($"Địa chỉ: {Street}, {City}");
        }
    }
}
