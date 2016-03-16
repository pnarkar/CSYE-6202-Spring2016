using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
   public class Program
    {
        static void Main(string[] args)
        {
            float salary = 0.0f;
            float GS = 0.0f;
            float CR = 0.0f;
            float hours = 0.0f;
            float BS = 0.0f;
            float earned =0.0f;
            Console.Write("Salaried Employee:");
            string rname = "^[a-zA-Z\\s]+$";
            String name = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(name, rname))
            {
                Console.Write("Social Security Number:");
                string sPattern = "^\\d{3}-\\d{2}-\\d{4}$";
                String number = Console.ReadLine();
                if (System.Text.RegularExpressions.Regex.IsMatch(number, sPattern))
                {
                    Console.Write("Weekly Salary:$");
                    
                    try {
                        salary = float.Parse(Console.ReadLine()); }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Environment.Exit(0);

                    }

                    catch (Exception e)
                    {


                        Console.WriteLine("Handling a System.Exception object");
                        Console.WriteLine("Message = " + e.Message);
                        Console.WriteLine("StackTrace = " + e.StackTrace);
                        Environment.Exit(0);

                    }
                    SalariedEmployee s = new SalariedEmployee(salary, number, name);
                    earned = s.calculateSalary();
                    Console.Write("Earned:$" + earned);
                    Console.ReadLine();

                    Console.Write("Hourly employee:");
                    name = Console.ReadLine();
                    if (System.Text.RegularExpressions.Regex.IsMatch(name, rname))
                    {
                        Console.Write("Social Security Number:");
                        number = Console.ReadLine();
                        if (System.Text.RegularExpressions.Regex.IsMatch(number, sPattern))
                        {
                            Console.Write("Hourly wage:$");
                           
                            try {
                                salary = float.Parse(Console.ReadLine());
                                Console.Write("Hours worked:$");
                                hours = float.Parse(Console.ReadLine()); }

                            catch (FormatException ee)
                            {
                                Console.WriteLine(ee.Message);
                                Environment.Exit(0);
                            }

                            catch (Exception ee)
                            {


                                Console.WriteLine("Handling a System.Exception object");
                                Console.WriteLine("Message = " + ee.Message);
                                Console.WriteLine("StackTrace = " + ee.StackTrace);
                                Environment.Exit(0);
                            }
                            HourlyEmployee e = new HourlyEmployee(salary, hours, number, name);
                            earned = e.calculateSalary();
                            Console.Write("Earned:$" + earned);
                            Console.ReadLine();

                            Console.Write("Commission employee:");
                            name = Console.ReadLine();
                            if (System.Text.RegularExpressions.Regex.IsMatch(name, rname))
                            {
                                Console.Write("Social Security Number:");
                                number = Console.ReadLine();

                                if (System.Text.RegularExpressions.Regex.IsMatch(number, sPattern))
                                {
                                    Console.Write("Gross Sales:$");
                                    try {
                                        GS = float.Parse(Console.ReadLine());
                                        Console.Write("Commission rate:");
                                        CR = float.Parse(Console.ReadLine()); }

                                    catch (FormatException ee)
                                    {
                                        Console.WriteLine(ee.Message);
                                        Environment.Exit(0);
                                    }

                                    catch (Exception ee)
                                    {


                                        Console.WriteLine("Handling a System.Exception object");
                                        Console.WriteLine("Message = " + ee.Message);
                                        Console.WriteLine("StackTrace = " + ee.StackTrace);
                                        Environment.Exit(0);
                                    }
                                    CommissionEmployee c = new CommissionEmployee(GS, CR, number, name);
                                    earned = c.calculateSalary();
                                    Console.Write("Earned:$" + earned);
                                    Console.ReadLine();



                                    Console.Write("Base salaried commission employee:");
                                    name = Console.ReadLine();
                                    if (System.Text.RegularExpressions.Regex.IsMatch(name, rname))
                                    {
                                        Console.Write("Social security number:");
                                        number = Console.ReadLine();
                                        if (System.Text.RegularExpressions.Regex.IsMatch(number, sPattern))
                                        {
                                            Console.Write("Gross Sales:$");
                                            try {
                                                GS = float.Parse(Console.ReadLine());
                                                Console.Write("Commission rate:");
                                                CR = float.Parse(Console.ReadLine());
                                                Console.Write("Base salary:");
                                                BS = float.Parse(Console.ReadLine()); }

                                            catch (FormatException ee)
                                            {
                                                Console.WriteLine(ee.Message);
                                                Environment.Exit(0);
                                            }

                                            catch (Exception ee)
                                            {


                                                Console.WriteLine("Handling a System.Exception object");
                                                Console.WriteLine("Message = " + ee.Message);
                                                Console.WriteLine("StackTrace = " + ee.StackTrace);
                                                Environment.Exit(0);

                                            }
                                            SalarybasedCommissiomEmployee sb = new SalarybasedCommissiomEmployee(GS, CR, BS, number, name);
                                            earned = sb.calculateSalary();
                                            Console.Write("Earned:$" + earned);
                                            Console.ReadLine();
                                        }
                                        else {
                                            System.Console.WriteLine(" - invalid SSN");
                                            Environment.Exit(0);


                                        }
                                    }

                                    else {
                                        System.Console.WriteLine(" - invalid name");
                                        Environment.Exit(0);


                                    }
                                }

                                else {
                                    System.Console.WriteLine(" - invalid SSN");
                                    Environment.Exit(0);


                                }

                            }

                            else {
                                System.Console.WriteLine(" - invalid name");
                                Environment.Exit(0);


                            }

                        }

                        else {
                            System.Console.WriteLine(" - invalid SSN");
                            Environment.Exit(0);


                        }
                    }

                    else {
                        System.Console.WriteLine(" - invalid name");
                        Environment.Exit(0);


                    }

                }
                else
                {
                    System.Console.WriteLine(" - invalid SSN");
                    Environment.Exit(0);
                }

            }

            else
            {
                System.Console.WriteLine(" - invalid name");
                Environment.Exit(0);
            }



        }
    }
}
