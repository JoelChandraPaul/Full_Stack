using System;

namespace Revised_Pos_Neg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }

        static void RunProgram()
        {
            while (true)
            {
                string input = GetUserInput();

                if (ShouldExit(input))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (!TryGetNumber(input, out int num))
                {
                    Console.WriteLine("Please enter a valid number.\n");
                    continue;
                }

                PrintNumberType(num);
                Console.WriteLine();
            }
        }

        static string GetUserInput()
        {
            Console.Write("Enter a number (or q to quit): ");
            return Console.ReadLine().Trim().ToLower();
        }

        static bool ShouldExit(string input)
        {
            return input == "q" || input == "exit";
        }

        static bool TryGetNumber(string input, out int num)
        {
            return int.TryParse(input, out num);
        }

        static void PrintNumberType(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("The number is neither positive nor negative");
            }
            else if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }
    }
}
