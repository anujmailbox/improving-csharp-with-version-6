using System;

namespace ExpressionBodiedMethodsAndProps
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("John", "Doe");

            Console.WriteLine(person.Greet("Jeremy"));

            Console.ReadKey();
        }
    }

    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public string FullName => $"{FirstName} {LastName}";

        public string Greet(string name) => $"Hello, {name}. My is {FullName}.";

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
