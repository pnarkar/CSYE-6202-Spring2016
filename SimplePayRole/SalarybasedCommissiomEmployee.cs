using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
   public class SalarybasedCommissiomEmployee : Employee

    {

        public float GrossSales;
        public float CommissionRate;
        public float BaseSalary;

        public SalarybasedCommissiomEmployee(float GS,float CR,float BS, string SecurityNumber, string name) : base(SecurityNumber, name)
        {
            GrossSales = GS;
            CommissionRate = CR;
            BaseSalary = BS;

        }

        public override float calculateSalary()
        {
            float sal = 0.0f;
            
                sal = BaseSalary + (GrossSales * CommissionRate); 

            
            return sal;
        }
    }
}
