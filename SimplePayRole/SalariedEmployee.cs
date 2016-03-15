using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
    class SalariedEmployee : Employee
    {
        public float WeekelySalary {get; private set;}

    public SalariedEmployee(float sal,string SecurityNumber, string name) : base(SecurityNumber, name)
        {
            WeekelySalary = sal;

        }

      
        public override float calculateSalary()
        {
        return WeekelySalary;
        }
    }
}
