using System;

namespace ExtractClass_After
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Tách thông tin liên lạc ra thành lớp riêng
            ContactInfo contact = new ContactInfo("0123456789", "123 Đường ABC, TP.HCM");

            // 🔹 Truyền ContactInfo vào Person
            Person person = new Person("Nguyen Van A", contact);

            person.DisplayInfo();
        }
    }

    // ✅ Lớp Person giờ chỉ giữ dữ liệu cá nhân
    class Person
    {
        public string Name { get; set; }
        public ContactInfo Contact { get; set; }

        public Person(string name, ContactInfo contact)
        {
            Name = name;
            Contact = contact;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Họ tên: {Name}");
            // 🔹 Gọi phương thức hiển thị của lớp ContactInfo
            Contact.DisplayContact();
        }
    }

    // ✅ Lớp ContactInfo mới được “Extract” ra từ Person
    class ContactInfo
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public ContactInfo(string phoneNumber, string address)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void DisplayContact()
        {
            Console.WriteLine($"Số điện thoại: {PhoneNumber}");
            Console.WriteLine($"Địa chỉ: {Address}");
        }
    }
}
