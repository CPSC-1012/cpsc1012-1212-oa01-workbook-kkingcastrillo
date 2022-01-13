/*  Purpose:    Sequence Structure Programming Exercises.
 * 
 *  Input:      # of the exercise; exercises' input variables.
 *  
 *  Output:     Multiple results.
 */
using System;

namespace SequenceStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string exercise;

            while (!check)
            {
                Console.Clear();

                Console.WriteLine("Enter # of the exercise to execute (1 to 5):");
                exercise = Console.ReadLine();

                switch (exercise)
                {
                    case "1":
                        exercise1();
                        break;
                    case "2":
                        exercise2();
                        break;
                    case "3":
                        exercise3();
                        break;
                    case "4":
                        exercise4();
                        break;
                    case "5":
                        exercise5();
                        break;
                    default:
                        Console.WriteLine("Not a valid option!");
                        break;
                }

                Console.WriteLine("Enter '0' to exit");
                check = Console.ReadLine() == "0";
            }
        }

        static void exercise1()
        {
            string name;
            int age;
            double annualPay;

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter expected annual salary:");
            annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C2} per year.");
        }

        static void exercise2()
        {
            double area, radius, lenght, volume, pi = 3.1416;

            Console.WriteLine("Enter radius and lenght of a cylinder:");
            radius = double.Parse(Console.ReadLine());
            lenght = double.Parse(Console.ReadLine());

            area = (radius * radius) * pi;
            volume = area * lenght;

            Console.WriteLine($"The area is {area:F3}. \n The volume is {volume:F3}.");
        }

        static void exercise3()
        {
            double lenght, area;

            Console.WriteLine("Enter the lenght of the side:");

            lenght = double.Parse(Console.ReadLine());
            area = ((3 * Math.Sqrt(3)) * Math.Pow(lenght, 2)) / 2;

            Console.WriteLine($"The area of the hexagon is {area:F3}");
        }

        static void exercise4()
        {
            string input;
            int number, digits = 0;

            Console.WriteLine("Enter a number between 0 and 1000:");
            input = Console.ReadLine();

            number = int.Parse(input);
            char[] inputDigits = input.ToCharArray();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                digits += int.Parse(inputDigits[i].ToString());
            }

            Console.WriteLine($"The sum of the digits is {digits}");
        }

        static void exercise5()
        {
            double investmentamount, interestRate, numberOfYears, futureInvestmentValue;

            Console.WriteLine("Enter investment amount:");
            investmentamount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate in percentage:");
            interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of years:");
            numberOfYears = double.Parse(Console.ReadLine());

            futureInvestmentValue = investmentamount * Math.Pow((1 + ((interestRate / 12) / 100)), (numberOfYears * 12));
            Console.WriteLine($"Future value is {futureInvestmentValue:C2}");
        }
    }
}
