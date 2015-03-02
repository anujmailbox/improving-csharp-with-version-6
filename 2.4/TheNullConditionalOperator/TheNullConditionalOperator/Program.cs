using System;


namespace TheNullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = null;

            var name = person?.FirstName?.ToLower();
            DateTime? now = DateTime.Now;
            var tomorrow = now?.AddDays(1);
        }

        static bool Foo(string data)
        {
            return data?.ToLower() == "foo";
            //if (data == null)
            //{
            //    return false;
            //}

            //return data.ToLower() == "foo";
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
