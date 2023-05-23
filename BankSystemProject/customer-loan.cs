using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject { 

    
    public partial class CustomerLoanPage : Form
    {
        public int ssn;
        public CustomerLoanPage()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
            string query = "select * from loan where loan_acc in(select account_number from hold_by where ssn =" + ssn.ToString() + ");";
            con.Adapt(query, "loan", dataGridView1);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            CustomerProfile form1 = new CustomerProfile();
            form1.ssn = ssn;
            form1.Show();
            Visible= false;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RequastLoan loan = new RequastLoan();
            loan.ssn = ssn;
            loan.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
