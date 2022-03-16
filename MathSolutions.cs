using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hculekConsoleDemoModules
{
    public static class MathSolutions
    {
        public static void ArraySumEvenNumbers() 
        {

            int a = 50;
            int[] numbers = new int[a];

            for (int i = 1; i < a+1; i++)
            {
                numbers[i - 1] = i;
            }
            var result = numbers.Where(i => i % 2 == 0).Sum(i=> (long)i);


            Console.WriteLine("\nSum of even numbers in array is {0}", result);

        }

    }
}
