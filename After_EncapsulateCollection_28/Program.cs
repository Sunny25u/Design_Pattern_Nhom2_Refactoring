using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RefactoringExample
{
    class Course
    {
        public string Name { get; set; }
        public Course(string name) => Name = name;
    }

    class Person
    {
        // Giữ danh sách private
        private List<Course> courses = new List<Course>();

        // Getter chỉ cho đọc (read-only)
        public ReadOnlyCollection<Course> Courses
        {
            get { return courses.AsReadOnly(); }
        }

        // Phương thức thêm và xóa an toàn
        public void AddCourse(Course course)
        {
            if (!courses.Contains(course))
                courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.AddCourse(new Course("Math"));
            p.AddCourse(new Course("Physics"));

            Console.WriteLine("Danh sách môn học:");
            foreach (var c in p.Courses)
                Console.WriteLine($"- {c.Name}");

            // ❌ Không thể chỉnh sửa trực tiếp p.Courses.Add() được nữa
            // ✅ Phải thông qua phương thức AddCourse hoặc RemoveCourse
        }
    }
}
