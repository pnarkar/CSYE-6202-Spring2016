using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class HourlyEmployee : Employee 
    {
        private double hourlyWage;
        private double hoursWorked { get; set; }
        public double HourlyWage
        {
            get
            {
                return hourlyWage;
            }
            set
            {
                hourlyWage = value;
                
            }
        }
        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
                
            }
        }
        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double hourlyWage, double hoursWorked) : base(firstName, lastName, socialSecurityNumber)
        {
           
           
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
        }
        public override double calculateEarnings()
        {
            if (hoursWorked <= 40)
                return hourlyWage * hoursWorked;
            else
                return 40 * hourlyWage + (hoursWorked - 40) * hourlyWage * 1.5;
        }
       
    }
}
