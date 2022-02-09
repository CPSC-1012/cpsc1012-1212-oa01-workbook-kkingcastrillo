/*
 * Purpose:         Program that allows user to do calculations based on user's selection.
 * 
 * Input:           Option value, value to convert.
 * 
 * Output:          Converted value, exit message, or error message.
 * 
 * Written by:      Kevin King
 * 
 * Written for:     Sam Wu
 * 
 * Section:         Lab 2 - OA01
 * */

using System;

namespace CPSC1012_Lab2_KevinKing
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectedOption;
            double value;

            Console.Write("*********************Conversion Calculator*********************\n\n");
            Console.Write("Please choose from the following menu\n\n\t1)Inches to Centimeters\n\t2)Yards to Meters\n\t3)Miles to Kilometers\n\t4)Exit\n\nSelection: ");

            selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                case "1":
                    Console.Write("\nPlease enter value in inches: ");
                    value = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{value} in = {(value * 2.54):F2} cm");
                    break;
                case "2":
                    Console.Write("\nPlease enter value in yards: ");
                    value = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{value} yd = {(value * 0.9144):F2} m");
                    break;
                case "3":
                    Console.Write("\nPlease enter value in miles: ");
                    value = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{value} mi = {(value * 1.609344):F2} km");
                    break;
                case "4":
                    Console.WriteLine("\nExit, Good Bye...");
                    break;
                default:
                    Console.WriteLine("\nInvalid option, Good Bye...");
                    break;
            }
        }
    }
}
