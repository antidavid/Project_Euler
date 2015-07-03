using System;
using System.Collections.Generic;

/// <summary>
/// Programmer : David Fletcher
/// Created : June 29, 2015
/// 
/// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
///
/// Find the sum of all the primes below two million.
/// </summary>
namespace Project_Euler.Ten
{
	public class Summation_of_Primes
	{
		public static void Entry ()
		{
			List<int> primes = new List<int> ();

			int num = 3;

			primes.Add (2);

			long total = 0;


			while (num < 2000000) {
				bool isPrime = true;
				foreach (int prime in primes) {
					if (prime * prime <= num) {
						if (num % prime == 0) {
							isPrime = false;
							break;
						} else {
							isPrime = true;
						}
					}
				}
				if (isPrime == true) {

					primes.Add (num);
				}
				num++;
			}

			Console.WriteLine ("calculating total");
			int time = 0;
			foreach (int prime in primes) {
				total = total + prime;

				if (time % 200 == 0)
					Console.Write (".");
				time++;
			}

			Console.WriteLine (total); 

			//	Remove all multiples of p from the l.
			//	set p equal to the next integer in l which has not been removed.
			//	Repeat steps 3 and 4 until p2 > N, all the remaining numbers in the list are primes

		}
	}
}

