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
    public partial class CustomerSignIn : Form
    {
        public CustomerSignIn()
        {
            InitializeComponent();
        }

        private void CustomerSignIn_Load(object sender, EventArgs e)
        {

        }

        private void Customersignin_signin_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            string q = "select * from customer,hold_by,account where hold_by.ssn =" +textBox1.Text +" AND account.acc_number ="+textBox2.Text+" AND account.acc_pass ="+textBox3.Text;
            conn.QueryMYSQL(q);
            CustomerProfile p = new CustomerProfile();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
