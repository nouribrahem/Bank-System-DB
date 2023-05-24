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
    public partial class EmployeeAddCustomer : Form
    {
        public int ID;
        public EmployeeAddCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddtheCustomer_Click(object sender, EventArgs e)
        {
           
            if (CustomerName.Text!="" && CustomerSSN.Text!="" && CustomerAddress.Text!="" && CustomerPhone.Text!="" && AccountNumber.Text!="" && AccountType.Text!="" && AccountBalance.Text!="")
            {
                DBconnection con = new DBconnection();
                string q = "select branch_num from eployee where emp_id = " + ID.ToString() + ";";
                string branch = con.show(q, "branch_num");
                string query = "insert into Customer(cus_name, cus_ass, cus_address, cus_phone, branch_num) values('" + CustomerName.Text + "'," + CustomerSSN.Text + ",'" + CustomerAddress.Text + "', " + CustomerPhone.Text + " , " + branch + " );";
                string q1 = "insert into Account(acc_number, acc_type, acc_balance) values(" + AccountNumber.Text +",'" + AccountType.Text +"'," + AccountBalance.Text+");";
                string q2 = "insert into hold_by values(" + CustomerSSN.Text + "," + AccountNumber.Text + ");";
                string q3 = "insert into serve values(" + CustomerSSN.Text + "," + ID.ToString() + ");";
                con.Query(query);

                con.Query(q1);
                con.Query(q2);
                con.Query(q3);
                MessageBox.Show("Cusomer added");
                
            }



     

        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            EmployeeListLoans emp = new EmployeeListLoans();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible = false;
        }

        private void EmpProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile p = new EmployeeProfile();
            p.ID = ID;
            p.Show();
            Visible = false;
        }

        private void lsCustomers_Click(object sender, EventArgs e)
        {
            EmployeeListCustomers employee= new EmployeeListCustomers();
            employee.ID = ID;
            employee.Show();
            Visible = false;
        }
    }
}
