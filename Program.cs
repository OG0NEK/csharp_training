using System;

namespace CreateStruct
{
    internal class Program
    {
        private struct Person
        {
            private readonly string firstName;
            private readonly string lastName;
            private readonly int age;
            private readonly Genders gender;

            public enum Genders : int
            {
                Male,
                Female
            }
            public Person(string firstName, string lastName, int age,Genders gender)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.gender = gender;
            }

            public override string ToString()
            {
                return $"{firstName} {lastName} ({gender}), age {age}";
            }
        }

        private static void Main(string[] args)
        {
            Person p = new Person("Tony", "Alien", 32,Person.Genders.Male);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}