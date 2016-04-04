using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfo;


namespace Student_Registration
{
    public partial class Main : Form
    {
        private List<StudentInfo.StudentInfo> studentin = new List<StudentInfo.StudentInfo>();
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioFullTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            studentin = RandomlyGeneratedStudents();
            infogrid.DataSource = studentin;
            comboDepartment.DataSource = ComboData();
        }

        public List<String> ComboData()
        {
            List<String> depart = new List<String>();
            depart.Add("Information Systems");
            depart.Add("International Affairs");
            depart.Add("Nursing");
            depart.Add("Pharmacy");
            depart.Add("Psychology");
            depart.Add("Professional Studies");
            depart.Add("Public Administration");

            return depart;
        }

        private List<StudentInfo.StudentInfo> RandomlyGeneratedStudents()
        {

            List<String> depart = new List<String>();
            depart.Add("Information Systems");
            depart.Add("International Affairs");
            depart.Add("Nursing");
            depart.Add("Pharmacy");
            depart.Add("Psychology");
            depart.Add("Professional Studies");
            depart.Add("Public Administration");
           // int secondsSinceMidnight = Convert.ToInt32(DateTime.Now.Subtract(DateTime.Today).TotalSeconds);
            Random r1 = new Random(DateTime.UtcNow.Minute);
            Random r2 = new Random(DateTime.UtcNow.Millisecond);
            Random r3 = new Random(DateTime.UtcNow.Second);
            Random r4 = new Random(DateTime.UtcNow.Hour);
            Random r5 = new Random(DateTime.UtcNow.Day);
            String v1 = depart[r1.Next(0, depart.Count - 1)].ToString();
            String v2 = depart[r2.Next(0, depart.Count - 1)].ToString();
            String v3 = depart[r3.Next(0, depart.Count)].ToString();
            String v4 = depart[r4.Next(0, depart.Count - 1)].ToString();
            String v5 = depart[r5.Next(0, depart.Count)].ToString();


            List<String> type = new List<String>();
            type.Add("Full Time");
            type.Add("Part Time");
            Random t = new Random(DateTime.UtcNow.Hour);
            Random t1 = new Random(DateTime.UtcNow.Millisecond);

            String valt = type[t.Next(0, type.Count)].ToString();
            String valt1 = type[t1.Next(0, type.Count-1)].ToString();


            Random rand = new Random(DateTime.UtcNow.Day);
            Random rand1 = new Random(DateTime.UtcNow.Hour);
            Random rand2 = new Random(DateTime.UtcNow.Minute);
            int iThree = rand.Next(100, 999);
            int iTwo = rand1.Next(33, 56);
            int iFour = rand2.Next(6666, 9999);
            int i1 = rand.Next(100, 999);
            int i2 = rand1.Next(20, 79);
            int i3 = rand2.Next(1000, 7777);
            int i4 = rand.Next(100, 200);
            int i5 = rand1.Next(11, 99);
            int i6 = rand2.Next(1111, 4444);
            int i7 = rand.Next(333, 888);
            int i8 = rand1.Next(10, 67);
            int i9 = rand2.Next(4444, 8549);
            int i10 = rand.Next(345, 492);
            int i11 = rand1.Next(19, 83);
            int i12= rand2.Next(4444, 8549);
            String  studentId = i4.ToString() + "-" + i8.ToString() + "-" + iFour.ToString();
            String studentId1 = i10.ToString() + "-" + i11.ToString() + "-" + iFour.ToString();
            String studentId2 = iThree.ToString() + "-" + i2.ToString() + "-" + i3.ToString();
            String studentId3 = i4.ToString() + "-" + i5.ToString() + "-" + i6.ToString();
            String studentId4 = i1.ToString() + "-" + iTwo.ToString() + "-" + i3.ToString();
            String studentId5 = iThree.ToString() + "-" + i2.ToString() + "-" + i9.ToString();
            String studentId6 = i7.ToString() + "-" + i5.ToString() + "-" + i12.ToString();
            String studentId7 = i10.ToString() + "-" + i8.ToString() + "-" + i9.ToString();
            String studentId8 = i7.ToString() + "-" + i11.ToString() + "-" + i6.ToString();
            String studentId9 = i1.ToString() + "-" + i2.ToString() + "-" + i12.ToString();

            StudentInfo.StudentInfo s1 = new StudentInfo.StudentInfo(studentId3,"Raj", "Kumar", v1, valt1);
            StudentInfo.StudentInfo s2 = new StudentInfo.StudentInfo(studentId1,"Neha", "Roy", v4, valt);
            StudentInfo.StudentInfo s3 = new StudentInfo.StudentInfo(studentId5,"Kareena", "Kapoor", v2, valt);
            StudentInfo.StudentInfo s4 = new StudentInfo.StudentInfo(studentId4,"Aish", "Rai", v3, valt1);
            StudentInfo.StudentInfo s5 = new StudentInfo.StudentInfo(studentId7,"SRK", "Khan", v5, valt);
            StudentInfo.StudentInfo s6 = new StudentInfo.StudentInfo(studentId6,"Salman", "Khan", v1, valt1);
            StudentInfo.StudentInfo s7 = new StudentInfo.StudentInfo(studentId9,"Raju", "Irani", v4, valt);
            StudentInfo.StudentInfo s8 = new StudentInfo.StudentInfo(studentId,"Sanjay", "Datt", v3, valt1);
            StudentInfo.StudentInfo s9 = new StudentInfo.StudentInfo(studentId2,"Deepika", "Padukon", v2, valt);
            StudentInfo.StudentInfo s10 = new StudentInfo.StudentInfo(studentId8,"Meena", "Kumari", v5, valt);


            List<StudentInfo.StudentInfo> students = new List<StudentInfo.StudentInfo>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            return students;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            StudenttRegistrationForm.StudentAdd s = new StudenttRegistrationForm.StudentAdd(studentin);
            s.newStudentAdded += AddEmployeeOnNewEmployeeAdded;
           
            s.Show();
        }



        private void AddEmployeeOnNewEmployeeAdded(object sender, EventArgs eventArgs)
        {
            var student = eventArgs as StudentInfo.StudentInfo;
            if (student != null)
            {
                infogrid.DataSource = null;
                studentin.Add(student);
                infogrid.DataSource = studentin;
            }
        }

        private void StudentEdited(object sender, EventArgs eventArgs)
        {
            var student = eventArgs as StudentInfo.StudentInfo;
            if (student != null)
            {
                infogrid.DataSource = null;
                //studentin.Add(student);
                infogrid.DataSource = studentin;
            }
        }

        private void StudentRemoved(object sender, EventArgs eventArgs)
        {
            var student = eventArgs as StudentInfo.StudentInfo;
            if (student != null)
            {
                infogrid.DataSource = null;
                studentin.Remove(student);
                infogrid.DataSource = studentin;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            StudentInfo.StudentInfo su = (StudentInfo.StudentInfo)infogrid.CurrentRow.DataBoundItem;
           

            StudenttRegistrationForm.EditStudent s = new StudenttRegistrationForm.EditStudent(su);
           

            s.editStudentAdded += StudentEdited;

            s.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            StudentInfo.StudentInfo su = (StudentInfo.StudentInfo)infogrid.CurrentRow.DataBoundItem;
            StudenttRegistrationForm.RemoveStudent suh = new StudenttRegistrationForm.RemoveStudent(su);
            suh.removestudent += StudentRemoved;
            suh.Show();
        }
    }

}