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
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
        {
            InitializeComponent();
        }

        private void AdminSignInButton_Click(object sender, EventArgs e)
        {
            DBconnection dBconnection = new DBconnection();
            string Q = "select * from admin where " + AdminId.Text + " = admin_id AND " + AdminPassword.Text + " = admin_pass";
            dBconnection.Query(Q);
            AdminProfile profile = new AdminProfile();
            profile.Show();
            /*profile.Name = Q;*/
            Visible = false;
        }
    }
}
