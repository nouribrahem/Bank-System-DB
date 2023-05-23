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
           if(EmployeeName.Text!="" && EmployeeID.Text!="" && BranchNumber.Text!=""&& EmployeePassword.Text!="" )
            {
                if (EmployeePassword.Text == EmployeeConfirmPassword.Text)
                {
                    DBconnection connection = new DBconnection();
                    string emplinfo = "insert into Eployee( emp_name,emp_id, branch_num, emp_pass) values('" + EmployeeName.Text + "'," + EmployeeID.Text + "," + BranchNumber.Text + ",'" + EmployeePassword.Text + "')";
                    int found = connection.Query(emplinfo);
                    if(found > 0)
                    {
                        EmployeeProfile employeeProfile = new EmployeeProfile();
                        employeeProfile.ID = Convert.ToInt32(EmployeeID.Text);
                        employeeProfile.Show();
                        Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("password not match!");
                }


            }
            else
            {
                MessageBox.Show("Empty Faild");
            }
    
        }


    }
}
