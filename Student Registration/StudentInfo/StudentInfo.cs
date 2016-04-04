using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class StudentInfo : EventArgs
    {
       
        public String studentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string EnrollmentType { get; set; }


        public StudentInfo(String Fname, String Lname,String depart,String type) {
            Random rand = new Random(DateTime.UtcNow.Hour);
            Random rand1 = new Random(DateTime.UtcNow.Millisecond);
            Random rand2 = new Random(DateTime.UtcNow.Day);
            int iThree = rand.Next(100, 921);
            int iTwo = rand1.Next(10, 83);
            int iFour = rand2.Next(1000, 9211);
            studentId= iThree.ToString() + "-" + iTwo.ToString() + "-" + iFour.ToString();
            FirstName = Fname;
            LastName = Lname;
            Department = depart;
            EnrollmentType = type;
        }


       
    }
}
