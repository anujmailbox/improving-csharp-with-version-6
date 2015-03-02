using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStatic.Extensions
{
    public static class StringExtensionsTwo
    {
        public static string ExtensionTwo(this string str)
        {
            return "ExtensionTwo() called on " + str;
        }
    }
}
