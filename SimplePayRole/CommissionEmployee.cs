using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
    class CommissionEmployee : Employee
    {
        public float GrossSales;
        public float CommissionRate;
        public CommissionEmployee(float GS, float CR, string SecurityNumber, string name) : base(SecurityNumber, name)
        {
            GrossSales = GS;
            CommissionRate = CR;

        }
        public override float calculateSalary()
        {
            float sal = 0.0f;
            sal = GrossSales * CommissionRate;
            return sal;
        }
    }
}
