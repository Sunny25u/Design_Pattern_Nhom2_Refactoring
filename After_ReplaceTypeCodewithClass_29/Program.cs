using System;

namespace RefactoringExample
{
    class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup("O");
        public static readonly BloodGroup A = new BloodGroup("A");
        public static readonly BloodGroup B = new BloodGroup("B");
        public static readonly BloodGroup AB = new BloodGroup("AB");

        public string Name { get; }

        private BloodGroup(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }

    class Person
    {
        private string name;
        private BloodGroup bloodGroup;

        public Person(string name, BloodGroup bloodGroup)
        {
            this.name = name;
            this.bloodGroup = bloodGroup;
        }

        public BloodGroup GetBloodGroup() => bloodGroup;

        public override string ToString() => $"{name} - Nhóm máu {bloodGroup}";
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person("An", BloodGroup.A);
            Console.WriteLine(p);
        }
    }
}
