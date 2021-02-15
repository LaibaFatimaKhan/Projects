using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;


namespace RestaurantManagement
{
    public partial class AddFood : Form
    {

        SqlConnection con;
        string val_global = "";


        public AddFood()
        {
            InitializeComponent();
        }

        private void DisplayData(string a)
        {
            DbConnection db = new DbConnection();

            con = db.conn;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "EXEC[Food Display] " + a;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SearchResult");

            dataGridView1.DataSource = ds.Tables["SearchResult"];
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Refresh();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu("A");
            this.Hide();
            Form.Show();
        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            if (textbox_CustomerNIC.Text == "" || textbox_StaffID.Text == "")
            {
                MessageBox.Show("Please Enter valid Food and Price");
            }
            else
            {

                string var = "";

                if (textbox_CustomerNIC.Text != "")
                {
                    var = var + "@FoodName = '" + textbox_CustomerNIC.Text + "'";
                }
                else
                {
                    var = var + "@FoodName = NULL";
                }

                Debug.WriteLine(var);

                if (textbox_StaffID.Text != "")
                {
                    var = var + "," + "@FoodPrice = '" + textbox_StaffID.Text + "'";
                }
                else
                {
                    var = var + "," + "@FoodPrice = NULL";
                }

                DbConnection db = new DbConnection();

                con = db.conn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();


            Debug.WriteLine("EXEC[Add Order]" + var);
            cmd.CommandText = "EXEC[Add Order]" + var;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            dataGridView1.Update();
            dataGridView1.Refresh();
            DisplayData(val_global);
            }

        }

        private void textbox_CustomerNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_StaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_View_Click(object sender, EventArgs e)
        {
            string var = "";

            if (textbox_CustomerNIC.Text != "")
            {
                var = var + "@FoodName = '" + textbox_CustomerNIC.Text + "'";
            }
            else
            {
                var = var + "@FoodName = NULL";
            }

            Debug.WriteLine(var);

            if (textbox_StaffID.Text != "")
            {
                var = var + "," + "@FoodPrice = '" + textbox_StaffID.Text + "'";
            }
            else
            {
                var = var + "," + "@FoodPrice = NULL";
            }
            val_global = var;
            DisplayData(var); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();

            con = db.conn;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string value1 = row.Cells[0].Value.ToString();
                    Debug.WriteLine("EXEC[Delete Order] @FoodId = '" + value1 + "'");
                    cmd.CommandText = "EXEC[Delete Order] @FoodId = '" + value1 + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

            }

            dataGridView1.Update();
            dataGridView1.Refresh();
            DisplayData(val_global);

            //cmd.CommandText = "EXEC[Delete Order], " + "@FoodID = "+var;
            //cmd.CommandType = CommandType.Text;

        }
    }
}
