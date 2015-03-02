using System;
using System.Collections.Generic;

namespace DictionaryInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var urls = new Dictionary<string, Uri>
            {
                {"google", new Uri("http://www.google.com") },
                {"microsoft", new Uri("http://www.microsoft.com") }
            };

            var urls2 = new Dictionary<string, Uri>
            {
                ["google"] = new Uri("http://www.google.com"),
                ["microsoft"] = new Uri("http://www.microsoft.com")
            };
        }
    }
}
