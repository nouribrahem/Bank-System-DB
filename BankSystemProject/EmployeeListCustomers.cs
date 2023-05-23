using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystemProject
{
    public partial class EmployeeListCustomers : Form
    {
        public int ID;
        public EmployeeListCustomers()
        {
            InitializeComponent();
        }

        private void EmployeeListCustomers_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            string query = "select * from Customer where cus_ass in(select ssn from serve where emp_id = " + ID.ToString()+")";
            con.Adapt(query, "Customer", dataGridView1);
         



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lsCustomers_Click(object sender, EventArgs e)
        {
            EmployeeListCustomers emp = new EmployeeListCustomers();
            emp.ID = ID;
            emp.Show();
            Visible = false;



        }

        private void AddCustomerpage_Click(object sender, EventArgs e)
        {
            EmployeeAddCustomer emp = new EmployeeAddCustomer();
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

        private void lsLoans_Click(object sender, EventArgs e)
        {
            EmployeeListLoans emp = new EmployeeListLoans();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }

        private void Salary_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible=false;
        }
    }
}
