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
    public partial class AddBankPage : Form
    {
        public AddBankPage()
        {
            InitializeComponent();
        }

        private void AddBank_Load(object sender, EventArgs e)
        {

        }

        private void AddNewBank_Click(object sender, EventArgs e)
        {
            DBconnection dBconnection = new DBconnection();
            if (BankAddress.Text != "" && BankAddress.Text != "" && BankCode.Text != "")
            {
                string Q = "insert into Bank values(' " + BankName.Text + "', '" + BankCode.Text  + "', '" + BankAddress.Text +"' );";
                dBconnection.Query(Q);
                MessageBox.Show("Bank Added!");
            }
            else
            {
                MessageBox.Show("Make sure to fill all the fields!");
            }
        }

        private void EmpProfile_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.Show();
            Visible = false;
        }

        private void AddBankBranch_Click(object sender, EventArgs e)
        {
            AdminAddBankBranch adminAddBankBranch = new AdminAddBankBranch();
            adminAddBankBranch.Show();
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
            Visible = false;
        }
    }
}
