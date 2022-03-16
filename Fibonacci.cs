using System;
using System.Collections.Generic;
using System.Text;

namespace hculekConsoleDemoModules
{
    public static class Fibonacci
    {
        public static void Get()
        {
            int a = 0;
            int b = 1;
            int c;

            string result = a + ", " + b;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                result += ", " + c;
            }

            Console.WriteLine("\nWriting Fibonacci sequence: \n" + result);
        }
    }
}
