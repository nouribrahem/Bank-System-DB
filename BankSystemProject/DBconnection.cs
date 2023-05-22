using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BankSystemProject
{
    internal class DBconnection
    {

        /// for MySQL//

        
        public DBconnection()
        {
            
        }
        public void Query(string query)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                MySqlCommand cmd = new MySqlCommand(); 
                cmd.Connection= con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //////////////////

        //public void Query(string query)
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = con;
        //        con.Open();
        //        cmd.CommandText = query;
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
