using System;

namespace HideDelegate_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department("Kỹ thuật", new Manager("Nguyen Van B"));
            Person person = new Person("Nguyen Van A", department);

            // ✅ Giờ chỉ cần gọi phương thức trung gian, không cần biết cấu trúc bên trong
            Console.WriteLine($"Quản lý của {person.Name} là: {person.GetManagerName()}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        private Department Department { get; set; }

        public Person(string name, Department department)
        {
            Name = name;
            Department = department;
        }

        // 🔹 Thêm phương thức trung gian để ẩn cấu trúc delegate
        public string GetManagerName()
        {
            return Department.Manager.Name;
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string name, Manager manager)
        {
            DepartmentName = name;
            Manager = manager;
        }
    }

    class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }
}
