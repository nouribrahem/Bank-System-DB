using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystemProject
{
    public partial class EmployeeAddCustomer : Form
    {
        public EmployeeAddCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddtheCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconncention = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconncention;
            sqlconncention.Open();
     

        }
    }
}
