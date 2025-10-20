using System;

namespace InlineClass_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Address và Person
            Address address = new Address("123 Đường ABC", "TP.HCM");
            Person person = new Person("Nguyen Van A", address);

            person.DisplayInfo();
        }
    }

    // 🔸 Lớp Person
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Họ tên: {Name}");
            Address.DisplayAddress();
        }
    }

    // ❌ Lớp Address quá nhỏ, chỉ có 2 thuộc tính, không cần thiết tách riêng
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Địa chỉ: {Street}, {City}");
        }
    }
}
