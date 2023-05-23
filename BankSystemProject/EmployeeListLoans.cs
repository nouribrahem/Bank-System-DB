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
    public partial class EmployeeListLoans : Form
    {
        public int ID;
        public EmployeeListLoans()
        {
            InitializeComponent();
        }

        private void EmployeeListLoans_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
           // string branch = "select branch_num from Eployee where emp_id = " + ID.ToString();
            string query = "select * from Loan where  in(select branch_num from Eployee where emp_id = " + ID.ToString()+ ")";
            con.Adapt(query, "Loan", dataGridView1);

        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible = false;
        }

        private void EmpProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile emp = new EmployeeProfile();
            emp.ID = ID;
            emp.Show();
            Visible= false;
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
    }
}
