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

        }
    }
}
