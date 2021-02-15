using System;
using System.Data;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class DbConnection
    {
        //Laiba Connection String
        //private static string myConnectionString = "Data Source=HU-DOPX-ML27;Initial Catalog=Project3;User ID=sa; password = M@lab9310SSe*!";
        private static string myConnectionString = @"server=LFK-HP\SQLEXPRESS;Initial Catalog=Project3;Integrated Security=True";
        //Shahzain Connection String
        //private static string myConnectionString = "server=DESKTOP-VEVG9RB;Initial Catalog=Project3;Integrated Security=True";
        //Kabir connection string
        //private static string myConnectionString = @"server=DESKTOP-09G2FL8\SQLEXPRESS;Initial Catalog=Project4 ;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(myConnectionString);
        public SqlCommand cmd = new SqlCommand();

        public DbConnection()
        {
            
        }

        public void Update(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;  
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Inserts(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Select(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void FillComboBox(ComboBox cb, string query)
        {
            conn.Open();
            cmd.CommandText = query;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            conn.Close();
        }
        public void FillComboBox_2(ComboBox cb, string query, string col)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataReader sq_reader;
            sq_reader = cmd.ExecuteReader();

            cb.Items.Clear();
            cb.Text = "";
            while (sq_reader.Read())
            {
                cb.Items.Add(sq_reader[col].ToString());
            }
            sq_reader.Close();
            conn.Close();
        }


        public int IncrementID(string query)
        {
            int id = -1;

            conn.Open();
            cmd.CommandText = query;
            SqlCommand command2 = new SqlCommand(query, conn);

            SqlDataReader reader = command2.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
                id = id + 1;
            }
            reader.Close();
            reader.Dispose();
            conn.Close();
            return id;
        }

        public bool CheckIfExists(string query)
        {
            bool exists = false;
            if (query != "")
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    exists = true;
                }
                else
                {
                    exists = false;
                }



                reader.Close();
                reader.Dispose();


                conn.Close();
            }

            return exists;

        }

        public void Deletes(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public string GetConnectionString()
        {
            return myConnectionString;
        }
    }

}
