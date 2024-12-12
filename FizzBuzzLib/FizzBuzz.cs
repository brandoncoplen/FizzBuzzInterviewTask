namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz
    {
        /// <summary>
        /// Simple fizzbuzz implementation, using Fizz=3 and Buzz=5
        /// </summary>
        /// <param name="input">The integer to convert</param>
        /// <returns>
        /// A string that contains "Fizz" if divisible by 3, "Buzz" if divisible by 5, 
        /// "FizzBuzz" if divisible by both, or the input as a string if none of these apply.
        /// </returns>
        public string FizzBuzzifyAnInt(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}

