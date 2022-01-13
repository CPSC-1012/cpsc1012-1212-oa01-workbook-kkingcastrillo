using System;

namespace Wages
{
    class Program
    {
        static void Main(string[] args)
        {
            double regularWages, basePay, regularHours, overTimeWages, overtimePay, overtimeHours, totalWages;
            bool check = false, rate, hours;

            while (!check)
            {
                Console.Clear();
                regularWages = 0;

                rate = parseDoubleInput("pay rate", out basePay);
                hours = parseDoubleInput("regular hours", out regularHours);

                if (rate == true && hours == true)
                {
                    regularWages = basePay * regularHours;


                    rate = parseDoubleInput("overtime pay rate", out overtimePay);
                    hours = parseDoubleInput("overtime hours", out overtimeHours);
                    overTimeWages = 0;

                    if (rate == true && hours == true)
                    {
                        overTimeWages = overtimePay * overtimeHours;
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }

                    totalWages = regularWages + overTimeWages;
                    Console.WriteLine($"Wages for this week are {totalWages:C}");
                }
                else
                {
                    check = false;
                }
            }
            Console.ReadLine();
        }

        static bool parseDoubleInput(string text, out double value)
        {
            string input = "";

            Console.WriteLine("Enter " + text);
            input = Console.ReadLine();

            if (double.TryParse(input, out value))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input error!");
                return false;
            }
        }
    }
}
