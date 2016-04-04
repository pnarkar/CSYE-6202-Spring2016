using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public abstract class Employee
    {
        private string nfirstName;
        private string nlastName;
        private string nsocialSecurityNumber;

        public string FirstName
        {
            get { return nfirstName; }
            set { nfirstName = value; }
        }

        public string LastName
        {
            get { return nlastName; }
            set { nlastName = value; }
        }

        public virtual string SocialSecurityNumber
        {
            get { return nsocialSecurityNumber; }
            set { nsocialSecurityNumber=value; }
        }

        public Employee(string firstName, string lastName, string ssn)
        {
            this.nfirstName = firstName;
            this.nlastName = lastName;
            this.nsocialSecurityNumber = ssn;
        }
       
        public abstract double calculateEarnings();

        }
}
