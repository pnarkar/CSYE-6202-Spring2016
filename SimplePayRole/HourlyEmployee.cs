using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
    public class HourlyEmployee : Employee
    {
        public float HourlyWage { get; private set; }
        public float HoursWorked { get; private set; }

        public HourlyEmployee(float HoWa, float HW, string SecurityNumber, string name) : base(SecurityNumber, name)
        {
            HourlyWage = HoWa;
            HoursWorked = HW;

        }
        public override float calculateSalary()
        {


            float sal = 0.0f;
            float bas = 0.0f;
            
                


                if (HoursWorked >= 1.00 && HoursWorked <= 40.00) { sal = HoursWorked * HourlyWage; }
                else { bas = 40 * HourlyWage;
                    sal = (float)(bas + (HoursWorked - 40.00) * HourlyWage * 1.50); }
               
            

           

            return sal;
        }
    }
}
