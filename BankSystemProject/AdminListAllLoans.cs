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
    public partial class AdminListAllLoans : Form
    {
        public AdminListAllLoans()
        {
            InitializeComponent();
        }

        private void AddBankBranch_Click(object sender, EventArgs e)
        {
            AdminAddBankBranch adminAddBankBranch = new AdminAddBankBranch();
            adminAddBankBranch.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddBankPage addBankPage = new AddBankPage();
            addBankPage.Show();
            Visible = false;
        }

        private void EmpProfile_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.Show();
            Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible = false;
        }

        private void AdminListAllLoans_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            // string branch = "select branch_num from Eployee where emp_id = " + ID.ToString();
            string query = "select loan_amount, loan_number, loan_type, loan_acc as loan_account, loan_status, loan_branch, cus_name as Customer_name , emp_name as Employee_name \r\nfrom loan , customer , eployee\r\nwhere cus_ass = (select ssn from hold_by where account_number = loan_acc)\r\nand emp_id = (select emp_id from serve where ssn = (select ssn from hold_by where account_number = loan_acc ));";
            con.Adapt(query, "Loan", listLoans_cusname_empname);
        }
    }
}
