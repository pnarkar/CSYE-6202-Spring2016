using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int att = 0;
        private void button1_Click(object sender, EventArgs e)

        {
            

            if (textUsername.Text == "Pranali" && textPassword.Text == "Password")
            {
                MessageBox.Show("Login Successful!!!");
                Main m = new Main();
                m.Show();
            }
            else if (att == 3) {
                MessageBox.Show("Crossed more than 3 attempts!!! Please try again later");
                this.Close();
            }
            else {
                att++;
                MessageBox.Show("Incorrect Credentials");
               
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
