using System;
using System.Globalization;

namespace NumberAnalyzer
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
                string input = GetInput();

                if (ShouldExit(input))
                {
                    Console.WriteLine("Exiting the program. Goodbye!...");
                    break;
                }

                if (!TryGetNumber(input, out int num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }
                
                NumberInfo(num);

                Console.WriteLine(); 
            }
        }

        static string GetInput()
        {
            Console.WriteLine("Enter a number:\nType q/exit to exit");
            return Console.ReadLine().Trim().ToLower();
        }

        static bool ShouldExit(string input)
        {
            return input == "q" || input == "exit";
        }

        static bool TryGetNumber(string input, out int number)
        {
           return int.TryParse(input, out number);
        }

        static void NumberInfo(int num)
        {
          Console.WriteLine(num % 2 == 0 ? $"{num} is Even" : $"{num} is Odd");
            if (num > 0)
                Console.WriteLine($"{num} is Positive");
            else if (num == 0)
                Console.WriteLine($"{num} is neither Positive nor Negative");
            else
                Console.WriteLine($"{num} is Negative");
          }
        }   
    }
