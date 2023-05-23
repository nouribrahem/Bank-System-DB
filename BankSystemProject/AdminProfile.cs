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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AddBankBranch_Click(object sender, EventArgs e)
        {
            AdminAddBankBranch adminAddBankBranch = new AdminAddBankBranch();  
            adminAddBankBranch.Show();
            Visible = false;
        }

        private void AddBank_Click(object sender, EventArgs e)
        {
            AddBankPage addBankPage = new AddBankPage();
            addBankPage.Show();
            Visible = false;
        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            AdminListAllLoans adminListAllLoans = new AdminListAllLoans();
            adminListAllLoans.Show();
            Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible=false;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            // string branch = "select branch_num from Eployee where emp_id = " + ID.ToString();
            string query = "select bank_name , bank.bank_code , bank_addr as bank_address , branch_num as branch_number , branch_add as branch_address \r\nfrom bank left join branches on bank.bank_code = branches.bank_code order by bank.bank_code , branch_num;";
            con.Adapt(query, "Loan", listbanks);
        }
    }
}
