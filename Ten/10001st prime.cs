using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programmer : David Fletcher
// Last Updated : 09 / 27 / 2014
// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10,001st prime number?
namespace Project_Euler.Ten
{
    class _10001st_prime
    {
        /// <summary>
        /// Solution to the 7th problem for Project Euler
        /// creates an array to place prime numbers into them
        /// compare new number by checking if previous primes divide in evenly
        /// </summary>
        public static void Entry()
        {
            int[] primes = new int[10001];
            int i = 1;
            int counter = 2;

            primes[0] = counter;
            // while the 10001 element in primes does not contain anything
            while (primes[10000] == 0)
            {
                counter++;
                // iterate through previous prime numbers
                for (int j = 0; j < i; j++)
                {
                    // check if the current prime number divides evenly into counter
                    // if it does break from for loop
                    if (counter % primes[j] == 0)
                    {
                        break;
                    }
                    // else if we have reached the last "filled" element in the array
                    // place the new prime number in the counter and increment the array position
                    else if (j == i-1) 
                    {
                        primes[i] = counter;
                        i++;
                    }
                        
                }
            }
            Console.WriteLine("Solution : {0}", primes[10000]);
        }
    }
}
