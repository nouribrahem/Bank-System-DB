using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace BankSystemProject
{
    internal class DBconnection
    {


        public DBconnection()
        {

        }
        /*
        public bool QuerySelect(string query)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
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
                MessageBox.Show(reader.HasRows.ToString());
                return reader.HasRows;

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
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
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


        public string show(string query, string column)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                con.Open();
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    string s = reader[column].ToString();
                    reader.Close();
                    con.Close();
                    return s;
                }
                reader.Close();
                con.Close();
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public void Adapt(string query, string table, DataGridView template)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=N157sql2003#;database=banksystem");
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
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
        */
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool QuerySelect(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
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
                SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
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
               // MessageBox.Show(ex.Message);
                return -1;
            }

        }

        public string show(string query, string column)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source= DESKTOP-N9PK8TN;Initial Catalog=BankSysttem;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    string s = reader[column].ToString();
                    reader.Close();
                    con.Close();
                    return s;
                }
                reader.Close();
                con.Close();
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public void Adapt(string query, string table, DataGridView template)
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

    }
}