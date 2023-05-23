using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject
{
    public partial class Employee_Update__details : Form
    {
        public int ID;
        public Employee_Update__details()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible = false;
        }

        private void update_details_Click(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            string query = "update Eployee set emp_name = '" + EmployeeName.Text + "'," + "branch_num = " + BranchNumber.Text + ", emp_pass = '" + EmployeePassword.Text + "' where emp_id = " + ID.ToString() + ";";
            con.Query(query);
            EmployeeProfile emp = new EmployeeProfile();
            emp.ID = ID;
            emp.Show();
            Visible = false;
               

        }

        private void EmpProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile emp = new EmployeeProfile();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }

        private void AddCustomerpage_Click(object sender, EventArgs e)
        {
            EmployeeAddCustomer emp = new EmployeeAddCustomer();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }

        private void lsCustomers_Click(object sender, EventArgs e)
        {
            EmployeeListCustomers emp = new EmployeeListCustomers();
            emp.ID = ID;
            emp.Show();
            Visible = false;

        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            EmployeeListLoans emp = new EmployeeListLoans();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }
    }
}
