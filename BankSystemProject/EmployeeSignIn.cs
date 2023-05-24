using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BankSystemProject
{
    public partial class SignIn : Form
    {
        public int ID;
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text != ""  && textBox2.Text != "")
            {
                DBconnection con = new DBconnection();
                string query = "select * from eployee where emp_id = " + textBox1.Text + " AND emp_pass = '" + textBox2.Text + "' ;";
                bool found = con.QuerySelect(query);
                ID = Convert.ToInt32(textBox1.Text);
                if (found)
                {
                    EmployeeProfile emp = new EmployeeProfile();
                    emp.ID = ID;
                    emp.Show();
                    Visible = false;

                }
                else
                {
                    MessageBox.Show("credentials are not correct!");
                }

            }
            else
            {
                MessageBox.Show("Missing Field");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            EmployeeSignUP employeesignup = new EmployeeSignUP();
            employeesignup.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            i.Show();
            Visible = false;
        }
    }
}
