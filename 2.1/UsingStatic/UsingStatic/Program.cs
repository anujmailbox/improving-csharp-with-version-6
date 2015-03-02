using System;
using System.IO;
using static System.Environment;
using static System.IO.Path;
using static System.IO.File;
using static System.IO.Directory;

using static UsingStatic.Extensions.StringExtensionsOne;


namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDocs = GetFolderPath(SpecialFolder.MyDocuments);
            var path = string.Format("{0}{1}file.txt", 
                myDocs, DirectorySeparatorChar);

            if (File.Exists(path))
            {
                var contents = ReadAllText(path);

                contents.ExtensionOne();
            }
        }
    }
}
