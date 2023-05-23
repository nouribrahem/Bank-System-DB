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
            string query = "select * from loan where loan_branch in(select branch_num from Eployee where emp_id = " + ID.ToString()+ ")";
            con.Adapt(query, "loan", dataGridView1);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loanNo.Text != "")
            {
                DBconnection con = new DBconnection();
                string query = "update loan set loan_status = 'Accepted' where loan_status = 'pending' AND loan_number = " + loanNo.Text + ";";
                int found = con.Query(query);
                if(found > 0)
                {
                    string ACbalance = "select acc_balance from account where acc_number in(select loan_acc from loan where loan_number = " + loanNo.Text + ");";
                    string acc_balance = con.show(ACbalance, "acc_balance");
                    string Lamount = "select loan_amount from loan where loan_number = " + loanNo.Text + ";";
                    string loan = con.show(Lamount, "loan_amount");
                    int total = Convert.ToInt32(acc_balance);
                    total += Convert.ToInt32(loan);
                    
                    string Query = "update account set acc_balance = "+total.ToString() +";";
                    con.Query(Query);
                    MessageBox.Show("loan accepted!");
                    
                }
                else
                {
                    MessageBox.Show("loan not found!");
                }
            }
            else
            {
                MessageBox.Show("empty field!");
            }
            EmployeeListLoans emp = new EmployeeListLoans();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loanNo.Text != "")
            {
                DBconnection con = new DBconnection();
                string query = "update loan set loan_status = 'rejected' where loan_status = 'pending' AND loan_number =" + loanNo.Text + ";";
                int found = con.Query(query);
                if (found > 0)
                {
                   
                    MessageBox.Show("loan rejected!");
                }
                else
                {
                    MessageBox.Show("loan not found!");
                }
            }
            else
            {
                MessageBox.Show("empty field!");
            }
            EmployeeListLoans emp = new EmployeeListLoans();
            emp.ID = ID;
            emp.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
