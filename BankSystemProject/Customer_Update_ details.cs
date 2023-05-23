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
    public partial class Customer_Update__details : Form
    {
        public int ssn;
        public Customer_Update__details()
        {
            InitializeComponent();
        }

        private void update_details_Click(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            string query = "update Customer set cus_name = '" + CustomerName.Text + "'," + "cus_address =' " + CustomerAddress.Text + "', Cus_phone = " + CustomerPhone.Text + " where cus_ass = " + ssn.ToString() + " ;";
            con.Query(query);
            CustomerProfile cus = new CustomerProfile();
            cus.ssn = ssn;
            cus.Show();
            Visible = false;
           
        }

        private void label10_Click(object sender, EventArgs e)
        {
            CustomerProfile cus = new CustomerProfile();

            cus.ssn = ssn;
            cus.Show();
            Visible=false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            CustomerLoanPage page = new CustomerLoanPage();
            page.ssn = ssn;
            page.Show();
            Visible = false;

        }
    }
}
