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

            Random r1 = new Random(DateTime.UtcNow.Minute);
            Random r2 = new Random(DateTime.UtcNow.Millisecond);
            Random r3 = new Random(DateTime.UtcNow.Second);
            String v1 = depart[r1.Next(0, depart.Count - 1)].ToString();
            String v2 = depart[r2.Next(0, depart.Count - 1)].ToString();
            String v3 = depart[r3.Next(0, depart.Count - 1)].ToString();


            List<String> type = new List<String>();
            type.Add("Full Time");
            type.Add("Part Time");
            Random t = new Random(DateTime.UtcNow.Hour);
            Random t1 = new Random();

            String valt = type[t.Next(0, type.Count - 1)].ToString();
            String valt1 = type[t1.Next(0, type.Count - 1)].ToString();

            StudentInfo.StudentInfo s1 = new StudentInfo.StudentInfo("Raj", "Kumar", v1, valt1);
            StudentInfo.StudentInfo s2 = new StudentInfo.StudentInfo("Neha", "Roy", v1, valt);
            StudentInfo.StudentInfo s3 = new StudentInfo.StudentInfo("Kareena", "Kapoor", v2, valt);
            StudentInfo.StudentInfo s4 = new StudentInfo.StudentInfo("Aish", "Rai", v3, valt1);
            StudentInfo.StudentInfo s5 = new StudentInfo.StudentInfo("SRK", "Khan", v2, valt);
            StudentInfo.StudentInfo s6 = new StudentInfo.StudentInfo("Salman", "Khan", v1, valt1);
            StudentInfo.StudentInfo s7 = new StudentInfo.StudentInfo("Raju", "Irani", v1, valt);
            StudentInfo.StudentInfo s8 = new StudentInfo.StudentInfo("Sanjay", "Datt", v3, valt1);
            StudentInfo.StudentInfo s9 = new StudentInfo.StudentInfo("Deepika", "Padukon", v1, valt);
            StudentInfo.StudentInfo s10 = new StudentInfo.StudentInfo("Meena", "Kumari", v1, valt);


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