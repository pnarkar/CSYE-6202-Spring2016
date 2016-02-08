using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {



        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            if (x % 3 == 0 && x % 5 == 0)
            {
                System.Console.WriteLine("FizzBuzz");

            }
            else if (x % 5 == 0)
            {
                System.Console.WriteLine("Buzz");

            }

            else if (x % 3 == 0)
            {
                System.Console.WriteLine("Fizz");

            }
            else {
                System.Console.WriteLine(x);
            }
        }
    }
}
