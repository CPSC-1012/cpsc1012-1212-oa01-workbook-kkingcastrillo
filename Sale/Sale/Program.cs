/* Purpose:         Compute the total of a sale item using the price and tax.
 * 
 * Inputs:          price in dolars and cents
 * 
 * Outups:          Sales total
 * 
 * Algorithm:   
 * 
 * Last modified:   2022-01-21
 */
using System;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double price, tax = 0.05, total;
            bool check = false;

            while (!check)
            {
                Console.WriteLine("Enter price");
                input = Console.ReadLine();

                if (double.TryParse(input, out price))
                {
                    price = double.Parse(input);
                    Console.WriteLine($"The price of the item is {price:C}");
                    total = price * tax;
                    Console.WriteLine($"The tax is {total:C}");
                    total = price + (price * tax);
                    Console.WriteLine($"The total is {total:C}");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Input error!");
                    check = false;
                }
            }
            Console.ReadLine();

        }
    }
}