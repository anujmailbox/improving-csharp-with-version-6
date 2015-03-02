using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "John";
            var lastName = "Doe";
            var person = new { FirstName = "John", LastName = "Doe" };

            //var message = string.Format("Hello {0} {1}", firstName, lastName);
            var message = $"Hello {person.FirstName} {person.LastName}";


            var date = DateTime.Now;
            //var dateMessage = string.Format("{0:yyyyMMdd}", date);
            var dateMessage = $"{date:yyyyMMdd}";
        }
    }
}
