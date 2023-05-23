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
    public partial class CustomerSignUP : Form
    {
        public CustomerSignUP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void SignUpCustomerFinish_Click(object sender, EventArgs e)
        {
            
            if(CustomerSSN.Text != "" && CustomerAccNumber.Text != "" && CustomerAccPassword.Text != "" && CustomerAccConfirmPassword.Text != "")
            {
                if(CustomerAccPassword.Text == CustomerAccConfirmPassword.Text)
                {
                    DBconnection con = new DBconnection();
                    string query = "update account set acc_pass = '" + CustomerAccPassword.Text + "' where acc_number = " + CustomerAccNumber.Text + " AND acc_pass = '0000';";
                    int found = con.Query(query);
                    if(found > 0)
                    {
                        CustomerProfile p = new CustomerProfile();
                        p.Show();
                        Visible= false;
                        p.ssn = Convert.ToInt32(CustomerSSN);
                    }
                    else
                    {
                        MessageBox.Show("no account for this number!");
                    }
                }
                else
                {
                    MessageBox.Show("passwords are not matched!");
                }
            }
            else
            {
                MessageBox.Show("empty fields!");
            }

        }
    }
}
