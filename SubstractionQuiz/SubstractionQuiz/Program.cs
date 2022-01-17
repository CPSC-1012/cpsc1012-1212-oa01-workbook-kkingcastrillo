using System;

namespace SubstractionQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random keygen = new Random();
            int number1 = keygen.Next(1, 10);
            int number2 = keygen.Next(1, 10);

            if (number1 < number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            Console.WriteLine($"What is {number1} - {number2} = ?");
            int answer = int.Parse(Console.ReadLine());

            if (number1 - number2 == answer)
            {
                Console.WriteLine("You are correct.");
            }
            else
            {
                Console.WriteLine("Your answer is wrong.");
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            }
        }
    }
}
