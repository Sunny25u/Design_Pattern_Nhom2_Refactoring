using System;

namespace ExtractClass_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Nguyen Van A", "0123456789", "123 Đường ABC, TP.HCM");
            person.DisplayInfo();
        }
    }

    // ❌ Lớp Person có quá nhiều thông tin (vừa cá nhân, vừa liên lạc)
    class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Person(string name, string phone, string address)
        {
            Name = name;
            PhoneNumber = phone;
            Address = address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Họ tên: {Name}");
            Console.WriteLine($"Số điện thoại: {PhoneNumber}");
            Console.WriteLine($"Địa chỉ: {Address}");
        }
    }
}
