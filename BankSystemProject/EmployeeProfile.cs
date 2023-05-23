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
    
    public partial class EmployeeProfile : Form
    {
        public int ID;
        public EmployeeProfile()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsCustomers_Click(object sender, EventArgs e)
        {
            EmployeeListCustomers employeeListCustomers = new EmployeeListCustomers();
            employeeListCustomers.Show();
            this.Hide();
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            string query = "select emp_name from Eployee where emp_id = " + ID.ToString() + " ;";
            label1.Text += con.show(query, "emp_id");
            query = "select emp_id from Eployee where emp_id = " + ID.ToString() + " ;";
            label3.Text += con.show(query, "emp_id");
            query = "select branch_num from Eployee where emp_id = " + ID.ToString() + " ;";
            label2.Text += con.show(query, "branch_num");
           
        }

        private void Salary_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerpage_Click(object sender, EventArgs e)
        {
            EmployeeAddCustomer emp = new EmployeeAddCustomer();
            emp.Show();
            Visible = false;
        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            EmployeeListLoans employeeListLoans = new EmployeeListLoans();
            employeeListLoans.ID = ID;
            employeeListLoans.Show();
            Visible = false;
        }
    }
}
