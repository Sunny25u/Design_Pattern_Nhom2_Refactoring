using System;
using System.Collections.Generic;

namespace RefactoringExample
{
    class Course
    {
        public string Name { get; set; }
        public Course(string name) => Name = name;
    }

    class Person
    {
        // Collection được public qua property (nguy hiểm)
        public List<Course> Courses { get; set; } = new List<Course>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Courses.Add(new Course("Math"));
            p.Courses.Add(new Course("Physics"));

            // Có thể trực tiếp thay thế toàn bộ danh sách!
            p.Courses = new List<Course> { new Course("Chemistry") };

            Console.WriteLine("Danh sách môn học:");
            foreach (var c in p.Courses)
                Console.WriteLine($"- {c.Name}");
        }
    }
}
