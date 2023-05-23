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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerSignIn customer= new CustomerSignIn();
            customer.Show();
            Visible= false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignIn emp = new SignIn();
            emp.Show();
            Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            AdminSignIn admin = new AdminSignIn();
            admin.Show();
            Visible = false;
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
