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
    public partial class EditStudent : Form
    {
        public event EventHandler editStudentAdded;
        StudentInfo.StudentInfo su;
        public EditStudent(StudentInfo.StudentInfo su)
        {
            InitializeComponent();
            this.su = su;
            
        }

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String fname = textBox2.Text;
            String lname = textBox3.Text;
            String depart = Convert.ToString(comboDepartment.SelectedItem);
            String type;

           
            if (radioPartTime.Checked)
            {
                type = "Part Time";

            }

            else { type = "Full Time"; }

            if (fname.Equals(null) || lname.Equals(null) || fname.Equals("") || lname.Equals(""))
            {
                MessageBox.Show("Please Fill in all the fields");

            }

            else {
                su.FirstName = fname;
                su.LastName = lname;
                su.Department = depart;
                su.EnrollmentType = type;
                
                DialogResult dialogResult = MessageBox.Show("Are You Sure you want to edit", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    editStudentAdded(this, su);
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

               
               
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

        private void EditStudent_Load(object sender, EventArgs e)
        {
            textBox1.Text = su.studentId;
            textBox2.Text = su.FirstName;
            textBox3.Text = su.LastName;
            comboDepartment.DataSource = ComboData();
            comboDepartment.SelectedItem = su.Department;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
