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
    public partial class CustomerLoanPage : Form
    {
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

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            CustomerProfile form1 = new CustomerProfile();
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
            loan.Show();
            Visible = false;
        }
    }
}
