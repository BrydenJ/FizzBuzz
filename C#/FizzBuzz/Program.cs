using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var inputStart = Convert.ToInt32(GetUserInput("Please enter a number to start from: "));
            var inputEnd = Convert.ToInt32(GetUserInput("Please enter a number to end at: "));
            for (var i = inputStart; i <= inputEnd; i++)
            {
                Console.WriteLine(FizzBuzzHelper.GetFizzBuzz(i));
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
