using Org.BouncyCastle.Utilities.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystemProject
{
    
    public partial class CustomerProfile : Form
    {
        public int ssn;
        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            string query = "select cus_name from Customer where cus_ass = " + ssn.ToString() + " ;";
            label1.Text += con.show(query,"cus_name");
            query = "select cus_ass from Customer where cus_ass = " + ssn.ToString() + " ;";
            label2.Text += con.show(query,"cus_ass");
            query = "select cus_phone from Customer where cus_ass = " + ssn.ToString() + " ;";
            label3.Text += con.show(query,"cus_phone");
            query = "select cus_address from Customer where cus_ass = " + ssn.ToString() + " ;";
            label4.Text += con.show(query,"cus_address");
            query = "select account_number from hold_by where ssn = " + ssn.ToString() + " ;";
            string acc = con.show(query, "account_number");
            label8.Text += acc;
            query = "select acc_type from Account where acc_number = " + acc + " ;";
            label10.Text += con.show(query,"acc_type");
            query = "select acc_balance from Account where acc_number = " + acc + " ;";
            label5.Text += con.show(query,"acc_balance");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //
        private void label7_Click(object sender, EventArgs e)
        {
             
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            CustomerLoanPage form2 = new CustomerLoanPage();
            form2.ssn= ssn;
            form2.Show();
            Visible = false;
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible = false;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
