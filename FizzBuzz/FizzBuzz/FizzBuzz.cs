namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            if (result % 3 == 0 && result % 5 == 0)
            {
                System.Console.WriteLine("FizzBuzz");

            }
            else if (result % 5 == 0)
            {
                System.Console.WriteLine("Buzz");

            }

            else if (result % 3 == 0)
            {
                System.Console.WriteLine("Fizz");

            }

            return result;
		}
	}
}
