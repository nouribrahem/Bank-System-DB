using System;
using System.Collections.Generic;
using System.Data;
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
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=a#r@w$a#2020123;database=banksystem");
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
        

        /*public void Adapt(string query, string table, DataGridView template)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, table);
                template.DataSource = ds;
                template.DataMember = table;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Query(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=TrueData Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }*/
    }
}
