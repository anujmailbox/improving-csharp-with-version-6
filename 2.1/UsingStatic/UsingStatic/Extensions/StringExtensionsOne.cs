using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStatic.Extensions
{
    public static class StringExtensionsOne
    {
        public static string ExtensionOne(this string str)
        {
            return "ExtensionOne() called on " + str;
        }
    }
}
