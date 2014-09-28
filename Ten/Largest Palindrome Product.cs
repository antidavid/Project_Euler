using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programmer : David Fletcher
// Solution to problem 4 of Project Euler
// Last Modified : 09 / 27 / 2014
// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Find the largest palindrome made from the product of two 3-digit numbers.
namespace Project_Euler
{
    class Largest_Palindrome_Product
    {
       
        public static void Entry()
        {
            int i = 999, j = 999;
            int num = 0, lrgPal = 0;

            // loop until largest palindrome is found
            while (true)
            {
                num = i * j; 
                // if a palindrome is found
                if (num == reverse(num))
                {
                    // if palindrome is larger than previous found palindrome
                    if (num > lrgPal)
                    {
                        lrgPal = i * j;
                    }              
                }
                // if the counters have dropped below 100
                if(j < 100 && i < 100)
                {
                    break;
                }
                // decrement j until it hits 100
                else if (j >= 100)
                {
                    j--;
                }
                // reset j to 999 and decrement i
                else if (j < 100)
                {
                    j = 999;
                    i--;
                }

            }


            Console.WriteLine("Solution : {0}", lrgPal);
        }

        /// <summary>
        /// Reverse the input and return result
        /// </summary>
        /// <param name="num">number to be reversed</param>
        /// <returns>return result (num reversed)</returns>
        static int reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
