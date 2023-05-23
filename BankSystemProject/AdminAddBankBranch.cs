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
    public partial class AdminAddBankBranch : Form
    {
        public AdminAddBankBranch()
        {
            InitializeComponent();
        }

        private void AddNewBankBranch_Click(object sender, EventArgs e)
        {
            DBconnection dBconnection = new DBconnection();
            string Q = "insert into Branches(branch_num, branch_add, bank_code) values( " + BranchNumber.Text+", '" + BranchAddress.Text+ "', " +AddBranchBankCode.Text+ " );" ;
            dBconnection.Query(Q);
            MessageBox.Show("Branch Added!");

        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            AdminListAllLoans adminListAllLoans = new AdminListAllLoans();  
            adminListAllLoans.Show();
            Visible = false;
        }
    }
}
