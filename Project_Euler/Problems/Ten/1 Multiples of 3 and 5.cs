using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programmer : David Fletcher
// Last Edited : 09 / 25 / 2014
// V 1.1
// Update i to start at 1 for efficency...
//
// Solution to Problem 1 of Project Euler
//
// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
// Solution : 233168
namespace Project_Euler.Ten
{
	class Multiples_of_3_and_5
    {
        /// <summary>
        /// Iterate 1 through 999
        /// if i % 3 or % 5 that = 0
        /// add to total
        /// </summary>
        public static void Entry(){
            Console.WriteLine("Project Euler : Problem 1");
            Console.WriteLine("Multiples of 3 and 5");

            int total = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total = total + i;
                }
            }

            Console.WriteLine("Solution : {0}", total);
        }
        
    }
}
