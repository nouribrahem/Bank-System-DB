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
        static long ssnIN;
        private void Customersignin_signin_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DBconnection conn = new DBconnection();
                string q = "select * from customer,hold_by,account where hold_by.ssn =" + textBox1.Text + " AND account.acc_number =" + textBox2.Text + " AND account.acc_pass =" + textBox3.Text;
                bool found = conn.QuerySelect(q);

                if (found)
                {
                    CustomerProfile p = new CustomerProfile();
                    p.ssn = Convert.ToInt32(textBox1.Text);
                    p.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("credentials are not correct!");
                }

            }
            else
            {
                MessageBox.Show("missing fields!");
            }



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

        private void label1_Click(object sender, EventArgs e)
        {
            CustomerSignUP s = new CustomerSignUP();
           
            s.Show();
            Visible = false;
        }
    }
}