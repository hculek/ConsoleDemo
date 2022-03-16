using System;
using System.Collections.Generic;
using System.Text;

namespace hculekConsoleDemoModules
{
    public static class Strings
    {
        public static void ReverseString()
        {
            //intentionally not using chararray and reverse function
            string a = "Quick brown fox.";
            string result = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }

            Console.WriteLine("\nString \"" + a + "\" typed backwards is " +
                "\"" + result + "\"");
        }

        public static void TrimAndLower()
        {
            string a = "Quick brown fox.";
            Console.WriteLine("\nString \"" + a + "\" to lower and without whitespace is " +
                "\"" + a.Replace(" ", String.Empty).ToLower() + "\"");
        }
    }
}
