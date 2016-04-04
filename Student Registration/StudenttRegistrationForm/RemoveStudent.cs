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
    public partial class RemoveStudent : Form
    {
        public event EventHandler removestudent;
        StudentInfo.StudentInfo su;
        public RemoveStudent(StudentInfo.StudentInfo su)
        {
            InitializeComponent();
            this.su = su;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            comboDepartment.DataSource = ComboData();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure you want to edit", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                removestudent(this, su);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
