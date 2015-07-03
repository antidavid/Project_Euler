using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programmer : David Fletcher
// Last Modified : 09 / 27 / 2014 
// The sum of the squares of the first ten natural numbers is,
// 12 + 22 + ... + 102 = 385
// The square of the sum of the first ten natural numbers is,
// (1 + 2 + ... + 10)2 = 552 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
namespace Project_Euler.Ten
{
    class Sum_Square_Difference
    {
        // Get the sum of the first 100 numbers
        // square it
        // subtract 1 - 100 squared individually from it
        public static void Entry()
        {
            long solution = 0;
            // get (1 + 2 + 3 + ... + 100)
            for (int i = 1; i <= 100; i++)
            {
                solution = solution + i;
            }
            // square it
            solution = solution * solution;
            // subtract 1^2, 2^2, ... 100^2 from solution
            for (int i = 1; i <= 100; i++)
            {
                solution = solution - (i * i);
            }
                Console.WriteLine("Solution : {0}", solution);
        }
    }
}
