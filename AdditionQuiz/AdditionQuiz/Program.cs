using System;

namespace AdditionQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minNumber = 1;
            const int maxNumber = 9;
            Random keygen = new Random();

            int number1 = keygen.Next(minNumber, maxNumber + 1);
            int number2 = keygen.Next(minNumber, maxNumber + 1);

            int correctAnswer = number1 + number2;

            Console.WriteLine($"What is {number1} + {number2} = ?");
            int userAnswer = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number1} + {number2} = {userAnswer} is {userAnswer == correctAnswer}");
        }
    }
}
