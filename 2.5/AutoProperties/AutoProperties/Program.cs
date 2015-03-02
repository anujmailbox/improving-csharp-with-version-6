using System.Collections.Generic;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public List<Person> Friends { get; } = new List<Person>();

    }
}
