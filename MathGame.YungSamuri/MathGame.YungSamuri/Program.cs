using System;

namespace MathGame.YungSamuri;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Math Game!");

        string? userInput = null;
        Random rng = new Random();

        do
        {
            Console.WriteLine("Please choose an operation or type \"exit\" to stop:\nadd, sub, mul, or div");
            userInput = Console.ReadLine();

            if (userInput == null)
            {
                Console.WriteLine("Please enter a valid operation name.");
                continue;
            }

            userInput = userInput.Trim().ToLower();

            switch (userInput)
            {
                case "add":
                    AddGame();
                    break;
                case "sub":
                    SubtractGame();
                    break;
                case "mul":
                    MultiplyGame();
                    break;
                case "div":
                    DivideGame();
                    break;
                default:
                    Console.WriteLine("Please enter a valid operation name.");
                    continue;
            }
        } while (userInput != "exit");

        void AddGame()
        {
            int num1 = rng.Next(0, 101);
            int num2 = rng.Next(0, 101);

            Console.WriteLine("Enter the correct answer:");
            Console.WriteLine($"{num1} + {num2}");

            do
            {
                userInput = Console.ReadLine();
                int answer = -1;

                if (userInput == null)
                {
                    Console.WriteLine("Please enter a valid number.");

                }
                else if (!int.TryParse(userInput, out answer))
                {
                    Console.WriteLine("Please enter a valid number.");
                    userInput = null;
                }
                else if (answer == num1 + num2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (userInput == null);
        }

        void SubtractGame()
        {
            Console.WriteLine("You are subtracting");
        }

        void MultiplyGame()
        {
            Console.WriteLine("You are multiplying");
        }

        void DivideGame()
        {
            Console.WriteLine("You are dividing");
        }

        //bool IsInputANumber(string? input, int output)
        //{
            
        //}
    }
}