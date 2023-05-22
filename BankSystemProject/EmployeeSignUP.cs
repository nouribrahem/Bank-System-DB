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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;

namespace BankSystemProject
{
    public partial class EmployeeSignUP : Form
    {
        public EmployeeSignUP()
        {
            InitializeComponent();
        }

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void SignUpEmployeeFinish_Click(object sender, EventArgs e)
        {
            
           DBconnection connection = new DBconnection();
            string emplinfo = "insert into Eployee( emp_name,emp_id, branch_num, emp_pass) values('"+EmployeeName.Text + "'," + EmployeeID.Text + "," + BranchNumber.Text + ",'" + EmployeePassword.Text + "')";


            if (EmployeeID.Text == "" && EmployeeName.Text=="" && BranchNumber.Text =="" && EmployeePassword.Text == "" && EmployeeConfirmPassword.Text == "")
            {
                MessageBox.Show("employee id and password are empty", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmployeePassword.Text == EmployeeConfirmPassword.Text)
            {
                connection.Query(emplinfo);
                MessageBox.Show("sign up successfuly!");

                EmployeeProfile emp = new EmployeeProfile();
                emp.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("password doesn't match", "please re-enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmployeePassword.Text = "";
                EmployeeConfirmPassword.Text = "";
                EmployeePassword.Focus();
            }

          


            /*
            else if(EmployeePassword.Text != null)
            {
                MessageBox.Show("this employee has account!");
            }
            */
        }


    }
}
