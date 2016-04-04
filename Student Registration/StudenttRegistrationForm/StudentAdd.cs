using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenttRegistrationForm
{
    public partial class StudentAdd : Form
    {
        public event EventHandler newStudentAdded;
        private List<StudentInfo.StudentInfo> student;
        public StudentAdd(List<StudentInfo.StudentInfo> student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            String fname= textBox2.Text;
            String lname = textBox3.Text;
            String depart = Convert.ToString(comboDepartment.SelectedItem);
            String type;
            if (radioPartTime.Checked) {
                type = "Part Time";

            }

            else { type = "Full Time"; }

            if (fname.Equals(null) || lname.Equals(null) || fname.Equals("") || lname.Equals(""))
            {
                MessageBox.Show("Please Fill in all the fields");
                
            }

            else {
                StudentInfo.StudentInfo newstudent = new StudentInfo.StudentInfo(fname, lname, depart, type);
                newStudentAdded(this, newstudent);

                this.Close();
            }
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

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            comboDepartment.DataSource = ComboData();
            enableadd();
        }


        public void enableadd() {
            if(!textBox2.Text.Equals(null) || !textBox3.Text.Equals(null) || !textBox2.Text.Equals("") || !textBox3.Text.Equals( ""))
            {
                buttonAdd.Enabled=true;
                buttonReset.Enabled = true;


            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
