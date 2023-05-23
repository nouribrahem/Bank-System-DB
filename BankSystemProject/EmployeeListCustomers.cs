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
          //  connection.Adapt(customerlist, "Customer", dataGridView1);

            connection.Query(customerlist);
  
                   
            */


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=TrueData Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Customer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
