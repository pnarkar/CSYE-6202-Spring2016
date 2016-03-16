using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class SalariedEmployee : Employee
    {
        private double weeklySalary;
        
        public SalariedEmployee(string firstName,string lastName, string socialSecurityNumber, double weeklySalary) : base(firstName,lastName,socialSecurityNumber)
        {
           
           
            this.weeklySalary = weeklySalary;
        }
        public double WeeklySalary
        {
            get { return weeklySalary;
               
            }
            set { weeklySalary = value;
               
            }
        }
        
       

        public override double calculateEarnings()
        {
            return weeklySalary;
        }
    }

}
