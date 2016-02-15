using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD(); 

			Console.ReadLine();
		}

		static void DisplayPatternA()
        {
            Console.Write("Pattern A");
            Console.WriteLine();
            for (int a = 1; a <= 10; a++) 
            {
                for (int b = 1; b <= a; b++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void DisplayPatternB()
        {
            Console.Write("Pattern B");
            Console.WriteLine();
            for (int a = 10; a >= 1; a--)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

		static void DisplayPatternC()
        {
            Console.Write("Pattern C");
            Console.WriteLine();
            for (int a = 10; a >= 1; a--) 
            {
                for (int b = 1; b <= 10 - a; b++)        
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= a; c++)  
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            } 
        }

		static void DisplayPatternD()
		{
            Console.Write("Pattern D");
            Console.WriteLine();
            for (int a = 1; a <= 10; a++)               
            {
                for (int b = 1; b <= 10 - a; b++)       
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= a; c++)  
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 
        }
	}
}
