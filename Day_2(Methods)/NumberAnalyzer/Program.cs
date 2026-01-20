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

                EvenOrOdd(num);
                PositiveOrNegative(num);

                Console.WriteLine(); 
            }
        }

        static string GetInput()
        {
            Console.WriteLine("Enter a number:\n Type q or exit to Stop the program");
            return Console.ReadLine().Trim().ToLower();
        }

        static bool ShouldExit(string input)
        {
            if (input == "q" || input == "exit")
            {
                return true;
            }
            return false;
        }

        static bool TryGetNumber(string input, out int number)
        {
            if (int.TryParse(input, out number))
            {
                return true;
            }
            return false;
        }

        static void EvenOrOdd(int num)
        {
            if(num%2 == 0)
            {
                Console.WriteLine($"{num} is Even");
            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }
        }

        static void PositiveOrNegative(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is Positive");
            }
            else if(num == 0)
            {
                Console.WriteLine($"{num} is neither Positive nor Negative");
            }
            else
            {
                Console.WriteLine($"{num} is Negative");
            }
        }
    }
}
