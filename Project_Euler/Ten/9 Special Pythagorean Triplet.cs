using System;

/// <summary>
/// Programmer : David Fletcher
/// Created : June 28, 2015
/// 
/// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
///
/// a2 + b2 = c2
///	For example, 32 + 42 = 9 + 16 = 25 = 52.
///
///	There exists exactly one Pythagorean triplet for which a + b + c = 1000.
///		Find the product abc.
/// </summary>
namespace Project_Euler
{
	public class __Special_Pythagorean_Triplet
	{
		public static void Entry ()
		{
			int a = 1;
			int b = 0;
			int c = 0;

			while (Pythagorean_Check (a, b, c) != true) {
				b++;
				c = 1000 - (a + b);

				if (c < 0) {
					a++;
					b = 0;
				}
			}


			/*do {
				a++;
				while (b != (1000 - a) || Pythagorean_Check (a, b, c) != true) {
					b++;
					c = 1000 - (a + b);
					if ( b == 1000)
					{
						a++;
						b = 0;
						break;
					}
				}
				b = 0;

			} while ( Pythagorean_Check(a,b,c) != true);*/
				
			Console.WriteLine ("a: {0}, b: {1}, c: {2}", a, b, c);
			Console.WriteLine ("Product : {0}", a * b * c);

		}

		// check to see if it validates pythagorean theorem
		static bool Pythagorean_Check (int a, int b, int c)
		{
			int asq = a * a;
			int bsq = b * b;
			int csq = c * c;

			if ((asq + bsq) == csq && (a+b+c) == 1000) {
				return true;
			} else {
				return false;
			}
		}
	}
}

