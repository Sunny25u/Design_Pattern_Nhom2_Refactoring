using System;

namespace RefactoringExample
{
    class Person
    {
        public static readonly int O = 0;
        public static readonly int A = 1;
        public static readonly int B = 2;
        public static readonly int AB = 3;

        private string name;
        private int bloodGroup;  // ❌ Type code: chỉ là số nguyên

        public Person(string name, int bloodGroup)
        {
            this.name = name;
            this.bloodGroup = bloodGroup;
        }

        public int GetBloodGroup() => bloodGroup;

        public override string ToString()
        {
            string[] groups = { "O", "A", "B", "AB" };
            return $"{name} - Nhóm máu {groups[bloodGroup]}";
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person("An", Person.A);
            Console.WriteLine(p);
        }
    }
}
