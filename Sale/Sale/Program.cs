using System;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            double price, tax, total;

            price = 29.75;
            tax = 1.76;
            total = 31.51;

            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax is {tax:C}");
            Console.WriteLine($"The total is {total:C}");
            Console.ReadLine();
        }
    }
}
