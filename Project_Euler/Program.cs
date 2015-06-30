using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Programmer : David Fletcher
// Solutions to the website Project Euler
// Last Modified : 09 / 27 / 2014
namespace Project_Euler
{
	class Program
	{
		/// <summary>
		/// Display header
		/// Enter infinite loop
		/// let user select the function to run and proceed as necessary
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			#region Header
			Console.ForegroundColor = ConsoleColor.Green;   // turn text green for funsies
			Console.WriteLine("Project Euler Solutions");
			Console.WriteLine("By: David Fletcher\n");
			#endregion

			// enter infinite loop
			while (true)
			{
				TextColor (false);
				// Display the Printed menu to the user
				Console.WriteLine();
				ReadMenu();

				#region User Input
				Console.WriteLine();
				Console.Write("opt : ");

				int opt = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
				#endregion

				// check to see if the user hasn't chosen to exit from the program
				if (opt != 0) 
				{
					TextColor(true);
					// opt sends the program to the designated location
					#region Menu Switch
					switch (opt)
					{
					case 1: Project_Euler.Ten.Multiples_of_3_and_5.Entry();         break;
					case 2: Project_Euler.Ten.Even_Fibonacci.Entry();               break;
					case 3: Project_Euler.Ten.Largest_Prime_Factor.Entry();         break;
					case 4: Project_Euler.Ten.Largest_Palindrome_Product.Entry();   break;
					case 5: Project_Euler.Ten.Smallest_Multiple.Entry();            break;
					case 6: Project_Euler.Ten.Sum_Square_Difference.Entry();        break;
					case 7: Project_Euler.Ten._10001st_prime.Entry(); 				break;
					case 8: Project_Euler.Ten.Largest_Product_in_a_Series.Entry(); 	break;
					case 9: Project_Euler.__Special_Pythagorean_Triplet.Entry(); 	break;
					case 10: Project_Euler.Summation_of_Primes.Entry(); 			break;
					}
					#endregion
				}
				// else the user has chosen to exit from the program
				else
				{
					break;
				}

			}
			// compensate for Visual Studio Auto Closing
			Console.WriteLine("Press any key to exit the program ...");
			Console.Read();
		}

		/// <summary>
		/// Print the menu held in the file Menu List.txt 
		/// stored in /bin/Debug
		/// </summary>
		static void ReadMenu()
		{
			string text = System.IO.File.ReadAllText(@"Menu List.txt");

			Console.WriteLine("{0}", text);
		}

		/// <summary>
		/// When this functions is called it changes the color of the text on the screen
		/// This makes it easier for users to differentiate what is the function and what is not
		/// </summary>
		/// <param name="function">function is a boolean to tell whether it is entering a function or not</param>
		static void TextColor(bool function)
		{
			if (function == false)
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
			}
			else if (function == true)
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}
		}
	}
}
