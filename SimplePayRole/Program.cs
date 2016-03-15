using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Salaried Employee:");
            String name = Console.ReadLine();
            Console.Write("Social Security Number:");
            String number = Console.ReadLine();
            Console.Write("Weekly Salary:$");
            float salary = float.Parse(Console.ReadLine());
            SalariedEmployee s = new SalariedEmployee(salary,number,name);
            float earned = s.calculateSalary();
            Console.Write("Earned:$"+earned);
            Console.ReadLine();

            Console.Write("Hourly employee:");
             name = Console.ReadLine();
            Console.Write("Social Security Number:");
             number = Console.ReadLine();
            Console.Write("Hourly wage:$");
             salary = float.Parse(Console.ReadLine());
            Console.Write("Hours worked:$");
            float hours=float.Parse(Console.ReadLine());
            HourlyEmployee e = new HourlyEmployee(salary,hours, number, name);
             earned = e.calculateSalary();
            Console.Write("Earned:$" + earned);
            Console.ReadLine();

            Console.Write("Commission employee:");
            name = Console.ReadLine();
            Console.Write("Social Security Number:");
            number = Console.ReadLine();
            Console.Write("Gross Sales:$");
            float GS = float.Parse(Console.ReadLine());
            Console.Write("Commission rate:");
            float CR = float.Parse(Console.ReadLine());
            CommissionEmployee c = new CommissionEmployee(GS, CR, number, name);
            earned = c.calculateSalary();
            Console.Write("Earned:$" + earned);
            Console.ReadLine();



            Console.Write("Base salaried commission employee:");
            name = Console.ReadLine();
            Console.Write("Social security number:");
            number = Console.ReadLine();
            Console.Write("Gross Sales:$");
             GS = float.Parse(Console.ReadLine());
            Console.Write("Commission rate:");
            CR = float.Parse(Console.ReadLine());
            Console.Write("Base salary:");
           float BS = float.Parse(Console.ReadLine());
           SalarybasedCommissiomEmployee sb = new SalarybasedCommissiomEmployee(GS, CR,BS, number, name);
            earned = sb.calculateSalary();
            Console.Write("Earned:$" + earned);
            Console.ReadLine();

        }
    }
}
