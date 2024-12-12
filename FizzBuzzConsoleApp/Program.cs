namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();

            Console.WriteLine("Enter an integer to FizzBuzzify:");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                string value = fizzBuzzer.FizzBuzzifyAnInt(input);
                Console.WriteLine($"Result: {value}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadKey();
        }
    }
}
