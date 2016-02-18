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

		static void Main(string[] args)
        {


            String type = "";
            String amount = "";
           Console.Write("Please Enter Purchased gas type,Q/q to quit:");
            type = Console.ReadLine();
            UserEnteredSentinelValue(type);
               
            
            
            Console.Write("Please Enter Purchased gas amount,Q/q to quit:");
            amount = Console.ReadLine();
            UserEnteredSentinelValue(amount);
            UserEnteredValidGasType(type);
            UserEnteredValidAmount(amount);






        }

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;


            if (userInput.Equals("q") || userInput.Equals("Q"))
            {
                result = true;
                System.Console.WriteLine("Application Terminated");
                //System.Environment.Exit(0);


            }

           

            return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;
            if (!userInput.Equals("r") && !userInput.Equals("R") && !userInput.Equals("p") && !userInput.Equals("P") && !userInput.Equals("m") && !userInput.Equals("M") && !userInput.Equals("d") && !userInput.Equals("D"))
            {
                result = false;
                System.Console.WriteLine("Invalid Gas Type");
                //System.Environment.Exit(0);
            }

            else if (userInput.Equals("")||userInput.Equals(" ") || userInput.Length > 1) {
                result = false;
                System.Console.WriteLine("Invalid Gas Type");

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

            else if (c.Equals('p') | (c.Equals('P')))
            {
                gasType = GasType.PremiumGas;
                

            }

            else if (c.Equals('m') | (c.Equals('M')))
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
			
            
		}
	}
}
