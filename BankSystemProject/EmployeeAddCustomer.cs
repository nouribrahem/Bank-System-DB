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
                string query = "insert into Customer ('" + CustomerName.Text + "'," + CustomerSSN.Text + "'," + CustomerAddress.Text + "'," + CustomerPhone.Text + "',";

            }



     

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
