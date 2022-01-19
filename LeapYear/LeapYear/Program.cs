using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            // Check if the year is a leap year
            // A leap year is divisible by 4
            bool isLeapYear = (year % 4 == 0);
            // A leap year is divisible by 4 but not by 100
            isLeapYear = isLeapYear && (year % 100 != 0);
            // A leap year is divisible by 4 but not by 100 or divisible by 400
            isLeapYear = isLeapYear || (year % 400 == 0);
            //bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            // Display the result
            Console.WriteLine($"{year} is a leap year? {isLeapYear}");
        }
    }
}
