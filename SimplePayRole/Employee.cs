using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRole
{
   abstract public class Employee
    {
        private static int count = 0;
        public string SecurityNumber { get;private set; }
        public string Name { get; private set; }


        public abstract float calculateSalary();

        

        public Employee(string SecurityNumber,string name)
        {
            Name = name;
            
        }
    }
}
