/*
 * Purpose:         Program for converting Teaspoons to Tablespoons
 * 
 * Input:           Increment value
 * 
 * Output:          List with converted values (tsp to tbsp) based on increment value
 * 
 * Written by:      Kevin King
 * 
 * Written for:     Sam Wu
 * 
 * Section:         Lab 3 - OA01
 */

using System;

namespace CPSC1012_Lab3_KevinKing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool returnProgram;
            int increment;
            int teaSpoons;
            decimal tableSpoons;

            returnProgram = false;

            while (!returnProgram)
            {
                Console.Clear();
                Console.Write("**********Conversion Table*********\n");
                Console.Write("Enter increment value (1-20): ");

                if (int.TryParse(Console.ReadLine(), out increment))
                {
                    if (increment >= 1 && increment <= 20)
                    {
                        teaSpoons = 1;

                        Console.Write("\nTea Spoons\tTable Spoons");
                        Console.Write("\n==========\t============");

                        while (teaSpoons <= 20)
                        {
                            tableSpoons = (decimal)teaSpoons / 3;

                            Console.Write($"\n{teaSpoons}\t\t{tableSpoons:F2}");

                            teaSpoons += increment;
                        }
                    }
                    else
                    {
                        Console.Write("\nThe increment value must be between 1 and 20!");
                    }
                }
                else
                {
                    Console.Write("\nInvalid input!");
                }

                Console.Write("\n\nWould you like to continue? (Y): ");

                returnProgram = Console.ReadLine().ToUpper().Trim() != "Y";
            }
        }
    }
}