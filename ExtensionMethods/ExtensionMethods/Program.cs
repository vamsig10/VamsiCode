using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(ExtensionMethods.ExtMethod("Hello "));
            var str2 = "Hey";
            Console.WriteLine(str2.ExtMethod());
            Console.Read();
        }
    }

    public static class ExtensionMethods
    {
        public static string ExtMethod(this string str)
        {
            return str + " ExtMethod";
        }
    }
}
