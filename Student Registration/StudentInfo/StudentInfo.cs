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
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Department { get; set; }
        public String EnrollmentType { get; set; }


        public StudentInfo(String Fname, String Lname,String depart,String type) {
            Random rand = new Random(DateTime.UtcNow.Day);
            Random rand1 = new Random(DateTime.UtcNow.Hour);
            Random rand2 = new Random(DateTime.UtcNow.Minute);
            int iThree = rand.Next(100, 999);
            int iTwo = rand1.Next(10,99);
            int iFour = rand2.Next(1000, 9999);
            studentId= iThree.ToString() + "-" + iTwo.ToString() + "-" + iFour.ToString();
            FirstName = Fname;
            LastName = Lname;
            Department = depart;
            EnrollmentType = type;
        }

        public StudentInfo(String id,String Fname, String Lname, String depart, String type)
        {
            studentId = id;
            FirstName = Fname;
            LastName = Lname;
            Department = depart;
            EnrollmentType = type;
        }


    }
}
