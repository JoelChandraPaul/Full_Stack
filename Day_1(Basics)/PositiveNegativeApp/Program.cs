
namespace PositiveNegativeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number (or press q to quit):");

                string input = Console.ReadLine().Trim().ToLower();

                if (input == "q")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                bool isValid = int.TryParse(input, out int num);

                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid number.\n");
                    continue;
                }

                if (num == 0)
                {
                    Console.WriteLine("The number is neither positive nor negative\n");
                }
                else if (num > 0)
                {
                    Console.WriteLine("The number is positive\n");
                }
                else
                {
                    Console.WriteLine("The number is negative\n");
                }
            }
        }
    }
}
f