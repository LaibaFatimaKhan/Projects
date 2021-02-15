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
    public partial class SearchOrder : Form
    {

        SqlConnection con;

        private string f;
        public SearchOrder(string staff)
        {
            f = staff;
            InitializeComponent();
        }

        private void DisplayData(string a)
        {
            DbConnection db = new DbConnection();

            con = db.conn;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "EXEC[Order Display] " + a;
            Debug.WriteLine("EXEC [Order Display] " + a);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SearchResult");

            dataGridView1.DataSource = ds.Tables["SearchResult"];
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Refresh();

        }


        private void SarchOrder_Load(object sender, EventArgs e)
        {

        }

        private void label_CustomerNIC_Click(object sender, EventArgs e)
        {

        }

        private void button_View_Click(object sender, EventArgs e)
        {
            AddOrders Form = new AddOrders("A");
            this.Hide();
            //Form.
            Form.ShowDialog();
        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            
            StaffUnPriv Form = new StaffUnPriv(f);
            this.Hide();
            Form.Show();
        }

        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_SearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void label_StaffID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string var = "";

            if (textbox_CustomerNIC.Text != "")
            {
                var = var + "@NIC = '" + textbox_CustomerNIC.Text + "'";
            }
            else
            {
                var = var + "@NIC = NULL";
            }

            if (textbox_OrderID.Text != "")
            {
                var = var + "," + "@OrderID = '" + textbox_OrderID.Text + "'";
            }
            else
            {
                var = var + "," + "@OrderID = NULL";
            }

            if (textbox_StaffID.Text != "")
            {
                var = var + "," + "@StaffID = '" + textbox_StaffID.Text + "'";
            }
            else
            {
                var = var + "," + "@StaffID = NULL";
            }

            if (datetimepicker_OrderDate.Value.ToString("yyyy-MM-dd") != "")
            {
                var = var + "," + " @OrderDate = '" + datetimepicker_OrderDate.Value.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                var = var + "," + " @OrderDate = NULL";
            }
            DisplayData(var);
        }

        private void textbox_CustomerNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_OrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_StaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Search_Click_1(object sender, EventArgs e)
        {
            string var = "";

            if (textbox_CustomerNIC.Text != "")
            {
                var = var + "@NIC = '" + textbox_CustomerNIC.Text + "'";
            }
            else
            {
                var = var + "@NIC = NULL";
            }

            if (textbox_OrderID.Text != "")
            {
                var = var + "," + "@OrderID = '" + textbox_OrderID.Text + "'";
            }
            else
            {
                var = var + "," + "@OrderID = NULL";
            }

            if (textbox_StaffID.Text != "")
            {
                var = var + "," + "@StaffID = '" + textbox_StaffID.Text + "'";
            }
            else
            {
                var = var + "," + "@StaffID = NULL";
            }

            if (datetimepicker_OrderDate.Value.ToString("yyyy-MM-dd") != "")
            {
                var = var + "," + " @OrderDate = '" + datetimepicker_OrderDate.Value.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                var = var + "," + " @OrderDate = NULL";
            }
            DisplayData(var);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datetimepicker_OrderDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}