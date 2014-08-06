namespace FizzBuzz
{
    using System.Globalization;

    public class FizzBuzzHelper
    {
        public static string GetFizzBuzz(int value)
        {
            if (value % 3 == 0 && value % 5 == 0) return "FizzBuzz";
            if (value % 3 == 0) return "Fizz";
            if (value % 5 == 0) return "Buzz";
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}