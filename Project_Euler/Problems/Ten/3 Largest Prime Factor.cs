using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programmer : David Fletcher
// Last Modified : 09 / 26 / 2014
//
// Problem 3 of Project Euler
// Largest Prime Factor
// V1.0
//
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
namespace Project_Euler.Ten
{
    class Largest_Prime_Factor
    {
        /// <summary>
        /// Takes the LargeNum 600851475143
        /// iterates through checking to see if number is divisible evenly
        /// do some math
        /// produce largest prime factor
        /// </summary>
        public static void Entry()
        {
            Console.WriteLine("Enter Largest Prime Factor");
            long LargeNum = 600851475143;

            // iterate through until the "halfway point" and check if number divides evenly into LargeNum
            for (int i = 2; i <= LargeNum / 2; i++)
            {
                // if it divides evenly into LargeNum do division and reassign LargeNum
                if (LargeNum % i == 0)
                {
                    LargeNum = LargeNum / i;
                    i = 2;
                }
            }
            Console.WriteLine("{0}", LargeNum);
        }
    }
}
