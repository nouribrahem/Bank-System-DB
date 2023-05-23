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
            string query = "select @label1.Text += from customer where cus_ass = " + ssn.ToString() + ";";
            //label1.Text += con.Adapt(query,"customer");
            query = "select @label2.Text += from customer where cus_ass = " + ssn.ToString() + ";";
            //label2.Text += con.Adapt(query,"customer");
            query = "select @label3.Text += from customer where cus_ass = " + ssn.ToString() + ";";
            //label3.Text += con.Adapt(query,"customer");
            query = "select label4.Text += from customer where cus_ass = " + ssn.ToString() + ";";
            label4.Text += con.Adapt(query,"customer");
            query = "select account_number from hold_by where ssn = " + ssn.ToString() + ";";
            label8.Text += con.Adapt(query,"customer");
            string acc = label8.Text;
            query = "select acc_type from account where acc_number = " + acc + ";";
            label10.Text += con.Adapt(query,"customer");
            query = "select acc_balance from account where acc_number = " + acc + ";";
            label5.Text += con.Adapt(query,"customer");

            query = "DECLARE @myOutputString AS VARCHAR(MAX) = ''; SELECT @myOutputString += concat(name, ' ', create_date, ' ', state_desc, char(13), char(10)) FROM sys.databases WHERE database_id < 9; print @myOutputString;";
            con.Query(query);
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
