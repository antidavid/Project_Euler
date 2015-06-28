using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programmer : David Fletcher
// Date Modified : 09 / 27 / 2014
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
namespace Project_Euler
{
    class Smallest_Multiple
    {
        
        public static void Entry()
        {
            // brute force method... because why not :D
            // its slow... inefficient but it gets the job done
            int solution = 1;
            while (solution % 2 != 0 || solution % 3 != 0 || solution % 4 != 0 || solution % 5 != 0 || solution % 6 != 0 || solution % 7 != 0 || solution % 8 != 0 || solution % 9 != 0 || solution % 10 != 0 ||
            solution % 11 != 0 || solution % 12 != 0 || solution % 13 != 0 || solution % 14 != 0 || solution % 15 != 0 || solution % 16 != 0 || solution % 17 != 0 || solution % 18 != 0 || solution % 19 != 0 || solution % 20 != 0)
            {
                solution++;
            }


            Console.WriteLine("Solution : {0}", solution);
        }
    }
}
