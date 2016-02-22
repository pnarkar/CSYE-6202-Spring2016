using System;
using static System.Net.Mime.MediaTypeNames;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None, 
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

        public static void Rec()
        {
            double t = 0.0;


            String amount = "";
            String z = "";
            Console.Write("Please Enter Purchased gas type,Q/q to quit:");
            String type = Console.ReadLine();
            if (UserEnteredSentinelValue(type) == true)
            {

                Environment.Exit(0);

            }
            


            Console.Write("Please Enter Purchased gas amount,Q/q to quit:");
            amount = Console.ReadLine();
            if (UserEnteredSentinelValue(amount) == true)
            {

                Environment.Exit(0);

            }
            if ((UserEnteredValidGasType(type) == true) && (UserEnteredValidAmount(amount) == true))
            {
                GasType a = GasTypeMapper(Convert.ToChar(type));
                double b = GasPriceMapper(a);
                int numVal = Convert.ToInt32(amount);

                Console.Write("You bought {0} Gallon of {1} at {2}", amount, a, b);
                Console.ReadLine();
                CalculateTotalCost(a, numVal, ref t);


                Rec();

            }

            else if ((UserEnteredValidGasType(type) == false) || (UserEnteredValidAmount(amount) == false)) {
                Console.WriteLine("please enter valid values");
                



                
                Rec();

            }
        }

		static void Main(string[] args)
        {

             Rec();
            Console.ReadLine();


        }

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
                      
			var result = false;


            if (userInput=="q" || userInput=="Q")
            {
                result = true;
                System.Console.WriteLine("Application Terminated");
              //Environment.Exit(0);
                

            }
           
                      

            return result;
	}
		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;
            if (userInput!="r" && userInput!="R" && userInput!="p" && userInput!="P" && userInput!="m" && userInput!="M" && userInput!="d"&& userInput!="D")
            {
                result = false;
                System.Console.WriteLine("Invalid ");
               // Environment.Exit(0);
            }

            else if (userInput.Equals("")||userInput.Equals(" ") || userInput.Length > 1) {
                result = false;
                System.Console.WriteLine("Invalid ");

            }

            else { result = true; }
			
			return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;

            double price;
            bool isDouble = Double.TryParse(userInput, out price);
            if (isDouble)
            {
                result = true;
               
                //System.Environment.Exit(0);
            }

            else { System.Console.WriteLine("Invalid amount entered"); }

            return result; 
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
            GasType gasType = GasType.None;
            if (c.Equals('r') || (c.Equals('R')))
            {
                 gasType = GasType.RegularGas;
                

            }

            else if (c.Equals('p') || (c.Equals('P')))
            {
                gasType = GasType.PremiumGas;
                

            }

            else if (c.Equals('m') || (c.Equals('M')))
            {
                gasType = GasType.MidgradeGas;


            }
            else if (c.Equals('d') || (c.Equals('D')))
            {
                gasType = GasType.DieselFuel;


            }

            return gasType;
           
            // your implementation here

            
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;
            if (gasType.Equals(GasType.RegularGas)) {
                result = 1.94;

            }

           else if (gasType.Equals(GasType.DieselFuel))
            {
                result = 2.17;

            }
           else if (gasType.Equals(GasType.MidgradeGas))
            {
                result = 2;

            }

         else if (gasType.Equals(GasType.PremiumGas))
            {
                result = 2.24;

            }

            return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            totalCost = 0.0;
            double result = 0.0;
            result = GasPriceMapper(gasType);

            totalCost = gasAmount * result;

            System.Console.WriteLine("Your total cost for this Purchase is {0}",totalCost);

        }
	}
}
