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
            
            SqlConnection sqlconnection = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select emp_id, emp_pass from Eployee where emp_id ='" + textBox1.Text + "'and emp_pass ='" + textBox2.Text + "'", sqlconnection);
            sqlconnection.Open();
            
            SqlDataReader re = cmd.ExecuteReader();
            if(re.Read() == true)
            {
                MessageBox.Show("sign in successfully!");
                EmployeeProfile profile = new EmployeeProfile();
                profile.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid id or password"," try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            sqlconnection.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {
            EmployeeSignUP employeesignup = new EmployeeSignUP();
            employeesignup.Show();
            this.Hide();
        }
    }
}
