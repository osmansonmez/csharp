using System;
using System.Collections.Generic;

namespace YieldSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in Power(2, 8))
            {
                Console.WriteLine("{0} ", i);
            }
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                Console.Write("Yielda girdi - ");
                yield return result;
            }
        }
    }
}
