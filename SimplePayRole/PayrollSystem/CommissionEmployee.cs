using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class CommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;

        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value;
                
            }
        }
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
                
            }
        }

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate) : base(firstName, lastName, socialSecurityNumber)
        {
            
            
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }
        public override double calculateEarnings()
        {
            return commissionRate * grossSales;
        }
       
    }
}
