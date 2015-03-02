using System;

namespace TheNameOfOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = nameof(Program.Main); // "Main"
        }

        public static void Foo(string bar)
        {
            if (bar == null)
            {
                throw new ArgumentNullException(nameof(bar));
                //throw new ArgumentNullException("baR");
            }
        }
    }
}
