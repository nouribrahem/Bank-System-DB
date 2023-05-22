using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystemProject
{
    public partial class EmployeeListCustomers : Form
    {
        public EmployeeListCustomers()
        {
            InitializeComponent();
        }

        private void EmployeeListCustomers_Load(object sender, EventArgs e)
        {
            /*
            
            DBconnection connection = new DBconnection();
            string customerlist = "select * from Customer";
            connection.Adapt(customerlist, "Customer", dataGridView1);

            connection.Query(customerlist);
            */
            SqlConnection conn = new SqlConnection();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
