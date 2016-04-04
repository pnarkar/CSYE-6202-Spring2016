using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class SalaryBasedCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;
           public double BaseSalary
        {
            get{ return baseSalary;}
            set { baseSalary=value;
               
            }
        }
           
        public SalaryBasedCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate, double baseSalary) : base(firstName,lastName,socialSecurityNumber,grossSales,commissionRate)
        {
           
            this.baseSalary = baseSalary;
        }
        public override double calculateEarnings()
        {
            return baseSalary + base.calculateEarnings();
        }
       
    }
}
