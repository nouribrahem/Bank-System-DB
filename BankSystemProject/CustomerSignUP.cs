﻿using System;
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
    public partial class CustomerSignUP : Form
    {
        public CustomerSignUP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpCustomerFinish_Click(object sender, EventArgs e)
        {
            DBconnection con = new DBconnection();


        }
    }
}
