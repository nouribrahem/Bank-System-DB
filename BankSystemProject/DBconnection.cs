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
        //selection
        public bool QuerySelect(string query)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                //MySqlDataReader reader = cmd.ExecuteReader();
                //reader.Close();
                object obj = cmd.ExecuteScalar();
                if (Convert.ToInt32(obj) > 0)
                {
                    MessageBox.Show(Convert.ToInt32(obj).ToString());
                    con.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show(Convert.ToInt32(obj).ToString());
                    con.Close();
                    return false;
                }
                //MessageBox.Show(reader.HasRows.ToString());
               // return reader.HasRows;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public int Query(string query)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                //MySqlDataReader reader = cmd.ExecuteReader();
                //reader.Close();
                int found = cmd.ExecuteNonQuery();
                con.Close();
                return found;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }
        //////////////////

        public string Adapt(string query, string table)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                //string s = da.ToString();
                DataSet ds = new DataSet();
                da.Fill(ds, table);
                con.Close();
                return s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        //public void Adapt(string query, string table, DataGridView template)
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
        //        con.Open();
        //        SqlDataAdapter da = new SqlDataAdapter(query, con);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, table);
        //        template.DataSource = ds;
        //        template.DataMember = table;
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //public void Query(string query)
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=TrueData Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
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
