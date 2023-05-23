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
    public partial class EmployeeListLoans : Form
    {
        public int ID;
        public EmployeeListLoans()
        {
            InitializeComponent();
        }

        private void EmployeeListLoans_Load(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();
           // string branch = "select branch_num from Eployee where emp_id = " + ID.ToString();
            string query = "select * from Loan where  in(select branch_num from Eployee where emp_id = " + ID.ToString()+ ")";
            con.Adapt(query, "Loan", dataGridView1);

        }

        private void lsLoans_Click(object sender, EventArgs e)
        {
            
        }
    }
}
