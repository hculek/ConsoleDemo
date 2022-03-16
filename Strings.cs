using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hculekConsoleDemoModules
{
    public static class Strings
    {
        public static void ReverseString()
        {
            //intentionally not using chararray and reverse function
            string s = "Quick brown fox.";
            string result = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }

            Console.WriteLine("\nString \"" + s + "\" typed backwards is " +
                "\"" + result + "\"");
        }

        public static void TrimAndLower()
        {
            string s = "Quick brown fox.";
            Console.WriteLine("\nString \"" + s + "\" to lower and without whitespace is " +
                "\"" + s.Replace(" ", String.Empty).ToLower() + "\"");
        }


        public static void RemoveCharacters() 
        {
            string s = "Quick brown $ fox $ jumps $ over lazy dog$.";
            GroupCollection gc = Regex.Match(s, @"([^$]*\$)(.*)").Groups;
            string result = gc[1].Value + gc[2].Value.Replace("$", "").Replace("  ", " ");
            Console.WriteLine("\nString \"{0}\" written without $: " +
                "\n \"{1}\"", s, result);
        }
    }
}
