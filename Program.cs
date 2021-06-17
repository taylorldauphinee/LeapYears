using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program.cs
/// June 17, 2021
/// Written by Taylor Dauphinee
/// Determines if a year is a leap year
/// </summary>

namespace LeapYears
{
    class Program
    {
        static void Main(string[] args)
        {
            bool year = false;
            string inputYear;
            // ask for a year input
            do
            {
                Console.WriteLine("Enter a year here: ");
                inputYear = Console.ReadLine();

                // check if the input is an integer
                char[] digits = inputYear.ToCharArray();
                for (int i = 0; i < digits.Length; i++)
                {
                    if (!Char.IsDigit(digits[i]))
                    {
                        Console.WriteLine("This is not a recognized year.");
                        year = false;
                        break;
                    }
                    year = true;
                }
            }
            while (!year);

            int numYear = Int32.Parse(inputYear);

            // determine if the year is a leap year
            if (numYear % 4 == 0)
            {
                if (numYear % 100 != 0 || numYear % 400 == 0)
                {
                    Console.WriteLine(numYear + " is a leap year!");
                }
                else
                {
                    Console.WriteLine(numYear + " is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine(numYear + " is not a leap year.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
