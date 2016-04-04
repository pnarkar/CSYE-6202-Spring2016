using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PayrollSystem
{
    public class Program
    {
        public enum EmployeeType
        {
            None,
            SalariedEmployee,
            HourlyEmployee,
            CommissionEmployee,
            SalaryBasedCommissionEmployee
        }


        public static void type()
        {
            string userEmployeeType = String.Empty;
            string userFirstName = String.Empty;
            string userLastName = String.Empty;
            string userFullName = userFirstName + userLastName;
            string userSSN = String.Empty;
            EmployeeType employeeType = EmployeeType.None;
            Console.Write(" Employee type: ");
            userEmployeeType = Console.ReadLine();
            if (ValidEmployee(userEmployeeType))
            {

               
                switch (userEmployeeType)
                {
                    case "SE":
                        Console.Write("Salaried Employee: ");
                        String userInputFullName = Console.ReadLine();
                        if (!ValidName(userInputFullName))
                        {
                            Console.WriteLine("Invalid Name!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            userFullName = userInputFullName;
                            Console.Write("Social security number: ");
                            String userInputSSN = Console.ReadLine();
                            if (!ValidSSN(userInputSSN))
                            {
                                Console.WriteLine("Invalid SSN!");
                                Environment.Exit(0);
                            }

                            else {

                                employeeType = EmployeeType.SalariedEmployee;
                                Console.Write("weekly salary: ");
                                Double userWeeklySalary = Double.Parse(Console.ReadLine());
                                if (userWeeklySalary > 0)
                                {
                                    SalariedEmployee se = new SalariedEmployee(userFirstName, userLastName, userSSN, userWeeklySalary);
                                    Console.Write("Earnings: ");
                                    Double userEarnings = se.calculateEarnings();
                                    Console.Write(userEarnings);
                                    Console.ReadLine();
                                    type();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Salary");
                                   
                                    Environment.Exit(0);
                                }


                            }
                        }

                        break;

                    case "HE":
                        Console.Write("Hourly Employee: ");
                       userInputFullName = Console.ReadLine();
                        if (!ValidName(userInputFullName))
                        {
                            Console.WriteLine("Invalid Name!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            userFullName = userInputFullName;
                            Console.Write("Social security number: ");
                            String userInputSSN = Console.ReadLine();
                            if (!ValidSSN(userInputSSN))
                            {
                                Console.WriteLine("Invalid SSN!");
                                Environment.Exit(0);
                            }

                            else {

                                employeeType = EmployeeType.HourlyEmployee;
                                Console.Write("Hourly wage: ");
                                Double userHourlyWage = Double.Parse(Console.ReadLine());
                                Console.Write("Hours worked: ");
                                Double userHoursWorked = Double.Parse(Console.ReadLine());
                                if (userHourlyWage > 0 && userHoursWorked > 0)
                                {
                                    HourlyEmployee he = new HourlyEmployee(userFirstName, userLastName, userSSN, userHourlyWage, userHoursWorked);
                                    Console.Write("Earnings: ");
                                    Double userEarnings = he.calculateEarnings();
                                    Console.Write(userEarnings);
                                    Console.ReadLine();
                                    type();
                                }
                                else
                                {
                                    Console.WriteLine("Wage or number of hours not valid");
                                   
                                    Environment.Exit(0);
                                }


                            }
                        }

                        break;

                    case "CE":
                        Console.Write("Commission Employee: ");
                         userInputFullName = Console.ReadLine();
                        if (!ValidName(userInputFullName))
                        {
                            Console.WriteLine("Invalid Name!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            userFullName = userInputFullName;
                            Console.Write("Social security number: ");
                            String userInputSSN = Console.ReadLine();
                            if (!ValidSSN(userInputSSN))
                            {
                                Console.WriteLine("Invalid SSN!");
                                Environment.Exit(0);
                            }

                            else {


                                employeeType = EmployeeType.CommissionEmployee;
                                Console.Write("Gross sales: ");
                                Double grossSales = Double.Parse(Console.ReadLine());
                                Console.Write("Commission rate: ");
                                Double commissionRate = Double.Parse(Console.ReadLine());
                                if (grossSales > 0 && commissionRate > 0)
                                {
                                    CommissionEmployee ce = new CommissionEmployee(userFirstName, userLastName, userSSN, grossSales, commissionRate);
                                    Console.Write("Earnings: ");
                                    Double userEarnings = ce.calculateEarnings();
                                    Console.WriteLine(userEarnings);
                                    Console.ReadLine();
                                    type();
                                }
                                else
                                {
                                    Console.WriteLine("Gross sales or commission rate not valid");
                                   
                                    Environment.Exit(0);
                                }


                            }
                        }
                        break;


                    case "BSCE":
                        Console.Write("Base salaried commission: ");
                         userInputFullName = Console.ReadLine();
                        if (!ValidName(userInputFullName))
                        {
                            Console.WriteLine("Invalid Name!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            userFullName = userInputFullName;
                            Console.Write("Social security number: ");
                            String userInputSSN = Console.ReadLine();
                            if (!ValidSSN(userInputSSN))
                            {
                                Console.WriteLine("Invalid SSN!");
                                Environment.Exit(0);
                            }

                            else {


                                employeeType = EmployeeType.CommissionEmployee;
                                Console.Write("Gross sales: ");
                                Double grossSales = Double.Parse(Console.ReadLine());
                                Console.Write("Commission rate: ");
                                Double commissionRate = Double.Parse(Console.ReadLine());
                                if (grossSales > 0 && commissionRate > 0)
                                {
                                    CommissionEmployee ce = new CommissionEmployee(userFirstName, userLastName, userSSN, grossSales, commissionRate);
                                    Console.Write("Earnings: ");
                                    Double userEarnings = ce.calculateEarnings();
                                    Console.WriteLine(userEarnings);
                                    Console.ReadLine();
                                    type();
                                }
                                else
                                {
                                    Console.WriteLine("Gross sales or commission rate are invalid");
                                    Environment.Exit(0);
                                }



                            }
                        }

                        break;











                }


            }
        }
    






































        
            public static void Main(string[] args)
        {
            type();
                           
        }
       
       
            public static float ValidInput(string userInputFloatValue)
        {
            float sales;
            if (float.TryParse(userInputFloatValue, out sales))
            {

                return sales;
            }
            else
                return -1;
           }

        public static bool ValidName(string userInputName)
        {
            if (String.IsNullOrEmpty(userInputName))
                return false;

            string npattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(userInputName, npattern);
        }

        public static bool ValidSSN(string ssn)
        {
            if (String.IsNullOrEmpty(ssn))
                return false;

            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            return Regex.IsMatch(ssn, pattern);
        }

        public static bool ValidEmployee(string userInput)
        {
            var result = false;


            if (userInput.Equals("SE") || userInput.Equals("HE") || userInput.Equals("CE") ||
               userInput.Equals("BSCE"))
            {
                result = true;
            }

            return result;
        }

    }
}


    

