﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystemProject
{

    public partial class RequastLoan : Form
    {
        public int ssn;
        public RequastLoan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RequestLoanFinish_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                DBconnection con = new DBconnection();
                string queryBranch = "select branch_num from customer where cus_ass = " + ssn.ToString() + ";";
                string branch = con.show(queryBranch, "branch_num");
                string queryAcc = "select account_number from hold_by where ssn = " + ssn.ToString() + ";";
                string account = con.show(queryAcc, "account_number");
                string query = "insert into loan(loan_type, loan_amount, loan_acc, loan_branch) values('" + comboBox1.Text + "' ," + textBox1.Text + " , " + account + ", " + branch + ");";
                con.Query(query);
                MessageBox.Show("loan requested successfully!");
                CustomerLoanPage loanPage = new CustomerLoanPage();
                loanPage.ssn = ssn;
                loanPage.Show();
                Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetItemsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string name in comboBox1.Items)
            {
                sb.Append(name);
                sb.Append(" ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void RequastLoan_Load(object sender, EventArgs e)
        {
            
        }

        private void RequastLoan_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("personal");
            comboBox1.Items.Add("industry");
            comboBox1.Items.Add("commercial");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}